using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials_Combined
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tutorials Combined, combines all of the information I've \npracticed in the other tutorials in one location." +
            "This line\nillustrates the same concept as the Hello World Tutorial.");
            Console.ReadLine();


            {
                Console.WriteLine("First is the if statement section of the tutorial, and a spelling bee.");
                Console.ReadLine();
                Console.WriteLine("Spell Potato");
                string spelling = Console.ReadLine();
                string message = "";
                if (spelling == "")
                    message = "Good job.";
                else message = "Nope";
                Console.WriteLine(message);
                Console.ReadLine();
                Console.WriteLine("Spell Pen");
                string secondSpelling = Console.ReadLine();
                string secondMessage = "";
                if (secondSpelling == "Pen")
                    secondMessage = "You've won a brand new car!";
                else secondMessage = "You've lose!";
                Console.WriteLine(secondMessage);
                Console.ReadLine();
            }
            {
                Console.WriteLine("If it works correctly it should output that Bill placed first, followed\n by George, followed by Paul, followed by John.");
                string[] names = new string[] { "Bill", "John", "George", "Paul" };
                string[] places = new string[] { "1st", "2nd", "3rd", "4th" };
                Console.WriteLine(names[0] + " " + places[0]);
                Console.WriteLine(names[2] + " " + places[1]);
                Console.WriteLine(names[3] + " " + places[2]);
                Console.WriteLine(names[1] + " " + places[3]);
                Console.ReadLine();

                Console.WriteLine("This is an example of a method being used to condense code! \n What would you like information about today? Cats, Naps, or Temperature");
                Decimal[] catWeights = new Decimal[] { 12.8M, 8.9M };
                Decimal avgCatWeights = FindAvg(catWeights);
                Decimal[] napsTakenWeek = new Decimal[] { 2, 1, 0, 1, 1, 2, 1 };
                Decimal avgNapsTaken = FindAvg(napsTakenWeek);
                Decimal[] avgTemperatureDay = new Decimal[] { 80, 77, 80, 75, 70, 79, 78 };
                Decimal avgTemperatureWeek = FindAvg(avgTemperatureDay);

                PickOne:
                string userValue = Console.ReadLine();
                if (userValue == "Cats")
                {
                    Console.WriteLine("Cats! The individual value of our cats' weights are...\n");
                    foreach (decimal catWeight in catWeights)
                        Console.WriteLine(catWeight + "lbs");
                    Console.WriteLine("...and the average weight of our cats is..." + avgCatWeights + "lbs");
                }

                else if (userValue == "Naps")
                {
                    Console.WriteLine("Naps! The number of naps taken each day this week are...\n");
                    foreach (decimal napsTakenDay in napsTakenWeek)
                        Console.WriteLine(napsTakenDay);
                    Console.WriteLine("...and the average number of naps I've taken taken per day is..." + napsTakenWeek);
                }

                else if (userValue == "Temperature")
                {
                    Console.WriteLine("Temperature! The average temperature each day this week was...\n");
                    foreach (decimal Temperature in avgTemperatureDay)
                        Console.WriteLine(Temperature + "°F");
                    Console.WriteLine("...and the average temperature this week was..." + avgTemperatureWeek + "°F");
                }

                else
                {
                    Console.WriteLine("Come on, just pick one.");
                    goto PickOne;
                }

                Console.ReadLine();
                Console.WriteLine("Next we use a StreamReader and while statement to read values from Values.txt and then output then to console.");
                Console.ReadLine();
                StreamReader myReader = new StreamReader("Values.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }

                myReader.Close();
                Console.ReadLine();
                Console.WriteLine("And here's how many days until I'm 10,000 days old, just to show some uses of the DateTime class");
                Console.ReadLine();
                DateTime myValue = DateTime.Now;
                DateTime myBirthday = DateTime.Parse("05/29/1990");
                TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
                DateTime tenThousandDaysAlive = myBirthday.AddDays(10000);
                Console.WriteLine(myAge.TotalDays);
                Console.WriteLine(tenThousandDaysAlive);
                Console.ReadLine();

                Console.WriteLine("Now, I'm going to demonstrate some of the principles\n" +
                  "Learned in the classes, more about classes and methods,\n" +
                  "classes and inheritances, working with" +
                  "references and\nassemblies, and enumerations and switch decision statements\ntutorial to display" +
                  "information about various types of\ninventory items)");
                Console.ReadLine();
                Console.WriteLine("Time for this thing.");
                Console.ReadLine();

                

                try
                {
                    bool myBool = true;
                    while (myBool == true)
                    myBool = inventoryConsole();
                    bool inventoryConsole()
                    {
                        Console.Clear();
                        Pickanitemtype:
                        Console.WriteLine("What would you like to know more about?\n1 - armor\n2 - food\n3 - potions\n4 - weapons\n5 - I don't need any information at this time.");
                        string responseItem = Console.ReadLine();
                        Console.Clear();

                        string[] secondMessage = new string[] {"What type of armor would you like to know about?\n1 - What about something for an archer?\n2 - " +
                                                            "I'm not very good at dodging, I take quite a few blows to the head.\n3 - Don't you have something" +
                                                            " a bit more... menacing?\n4 - Nevermind, I actually don't need any information about armor now.\n5 - " +
                                                            "Nevermind, I actually don't need any information now.",

                                                            "What type of food would you like to know about?\n1 - What about a hearty meal?\n2 - " +
                                                            "What about a sweet meal?\n3 - Don't you have something a bit more... menacing?\n4 - Nevermind," +
                                                            " I actually don't need any information about food now.\n5 - Nevermind, I " +
                                                            "actually don't need any information now.",

                                                            "What type of potion would you like to know about?\n1 - What about something for my health?\n2 - " +
                                                            "What about something for my mind?\n3 - Don't you have something a bit more... menacing?\n4 - Nevermind," +
                                                            " I actually don't need any information about potions now.\n5 - Nevermind, I " +
                                                            "actually don't need any information now.",

                                                            "What type of weapon would you like to know about?\n1 - What about a sword?\n2 - " +
                                                            "What about a bow?\n3 - Don't you have something more... menacing?\n4 - Nevermind," +
                                                            " I actually don't need any information about weapons now.\n5 - Nevermind, I " +
                                                            "actually don't need any information now."};


                        if (responseItem == "1")
                        {
                            Pickitem:
                            Console.WriteLine(secondMessage[0]);
                            string secondResponseItem = Console.ReadLine();
                            if (secondResponseItem == "1")
                            {
                                PrintArmorDetails(0);
                                return true;
                            }
                            if (secondResponseItem == "2")
                            {
                                Console.WriteLine("and the brain damage.");
                                Console.ReadLine();
                                Console.WriteLine("and the brain damage.");
                                Console.ReadLine();
                                Console.WriteLine("and the brain damage.");
                                Console.ReadLine();
                                PrintArmorDetails(1);
                                return true;
                            }
                            if (secondResponseItem == "3")
                            {
                                PrintArmorDetails(2);
                                return true;
                            }
                            if (secondResponseItem == "4")
                            {
                                Console.Clear();
                                return true;
                            }
                            if (secondResponseItem == "5")
                            {
                                Console.Clear();
                                return false;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sorry, I didn't get that.");
                                Console.ReadLine();
                                Console.Clear();
                                goto Pickitem;
                            }
                        }

                        if (responseItem == "2")
                        {
                            PickItem:
                            Console.WriteLine(secondMessage[1]);
                            string secondResponseItem = Console.ReadLine();
                            if (secondResponseItem == "1")
                            {
                                PrintFoodDetails(3);
                                return true;
                            }
                            if (secondResponseItem == "2")
                            {
                                PrintFoodDetails(4);
                                return true;
                            }
                            if (secondResponseItem == "3")
                            {
                                PrintFoodDetails(5);
                                return true;
                            }
                            if (secondResponseItem == "4")
                            {
                                Console.Clear();
                                return true;
                            }
                            if (secondResponseItem == "5")
                            {
                                Console.Clear();
                                return false;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sorry, I didn't get that.");
                                Console.ReadLine();
                                Console.Clear();
                                goto PickItem;
                            }
                        }

                        if (responseItem == "3")
                        {
                            PickItem:
                            Console.WriteLine(secondMessage[2]);
                            string secondResponseItem = Console.ReadLine();
                            if (secondResponseItem == "1")
                            {
                                PrintPotionDetails(6);
                                return true;
                            }
                            if (secondResponseItem == "2")
                            {
                                PrintPotionDetails(7);
                                return true;
                            }
                            if (secondResponseItem == "3")
                            {
                                PrintPotionDetails(8);
                                return true;
                            }
                            if (secondResponseItem == "4")
                            {
                                Console.Clear();
                                return true;
                            }
                            if (secondResponseItem == "5")
                            {
                                Console.Clear();
                                return false;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sorry, I didn't get that.");
                                Console.ReadLine();
                                Console.Clear();
                                goto PickItem;
                            }
                        }

                        if (responseItem == "4")
                        {
                            PickItem:
                            Console.WriteLine(secondMessage[3]);
                            string secondResponseItem = Console.ReadLine();
                            if (secondResponseItem == "1")
                            {
                                PrintWeaponDetails(9);
                                return true;
                            }
                            if (secondResponseItem == "2")
                            {
                                PrintWeaponDetails(10);
                                return true;
                            }
                            if (secondResponseItem == "3")
                            {
                                PrintWeaponDetails(11);
                                return true;
                            }
                            if (secondResponseItem == "4")
                            {
                                Console.Clear();
                                return true;
                            }
                            if (secondResponseItem == "5")
                            {
                                Console.Clear();
                                return false;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Sorry, I didn't get that.");
                                Console.ReadLine();
                                Console.Clear();
                                goto PickItem;
                            }
                        }

                        if (responseItem == "5")
                        {
                            return false;
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Sorry, I didn't get that.");
                            Console.ReadLine();
                            Console.Clear();
                            goto Pickanitemtype;

                        }
                    }

                }
                catch (DirectoryNotFoundException error)
                {
                    Console.WriteLine("Couldn't find Directory. Are you sure the directory exists?");
                }
                catch (FileNotFoundException error)
                {
                    Console.WriteLine("File not found. Are you sure the file is in the correct location?");
                }
                catch (Exception error)
                {
                    Func<string> dateTime;
                    Console.WriteLine("Something didn't work correctly {0}, {1}", dateTime =DateTime.Now.ToShortTimeString, error.Message);
                }



            }
        }



        private static decimal FindAvg(params Decimal[] values)
            {

                Decimal total = values.Sum();
                Decimal numberValues = values.Length;
                Decimal average = total / numberValues;
                return average;
            }

        

        public static void PrintArmorDetails(int itemID)
        {
            Console.Clear();

            string[] itemAttackRatingString = File.ReadAllLines("itemAttackRating.txt");
            int[] itemAttackRatingInt = itemAttackRatingString.Select(x => int.Parse(x)).ToArray();
            string[] itemDefenseRatingString = File.ReadAllLines("itemDefenseRating.txt");
            int[] itemDefenseRatingInt = itemDefenseRatingString.Select(x => int.Parse(x)).ToArray();
            string[] itemEffect = File.ReadAllLines("itemEffect.txt");
            string[] itemEnergyString = File.ReadAllLines("itemEnergy.txt");
            int[] itemEnergyInt = itemEnergyString.Select(x => int.Parse(x)).ToArray();
            string[] itemExpertisePenaltyString = File.ReadAllLines("itemExpertisePenalty.txt");
            int[] itemExpertisePenaltyInt = itemExpertisePenaltyString.Select(x => int.Parse(x)).ToArray();
            string[] itemlist = File.ReadAllLines("itemList.txt");
            string[] itemMovementPenaltyString = File.ReadAllLines("itemMovementPenalty.txt");
            int[] itemMovementPenaltyInt = itemMovementPenaltyString.Select(x => int.Parse(x)).ToArray();
            string[] itemPalitabilityString = File.ReadAllLines("itemPalitability.txt");
            int[] itemPalitabilityInt = itemPalitabilityString.Select(x => int.Parse(x)).ToArray();
            string[] itemQuality = File.ReadAllLines("itemQuality.txt");
            string[] itemType = File.ReadAllLines("itemType.txt");
            string[] itemValueString = File.ReadAllLines("itemValue.txt");
            int[] itemValueInt = itemValueString.Select(x => int.Parse(x)).ToArray();
            string[] itemWeightString = File.ReadAllLines("itemWeight.txt");
            int[] itemWeightInt = itemWeightString.Select(x => int.Parse(x)).ToArray();

            Item item = new Armor
            {

                Name = itemlist[itemID],
                Value = itemValueInt[itemID],
                Weight = itemWeightInt[itemID],
                Quality = itemQuality[itemID],
                Type = itemType[itemID],
                DefenseRating = itemDefenseRatingInt[itemID],
                MovementPenalty = itemMovementPenaltyInt[itemID],
                Effect = itemEffect[itemID]
            };

            Console.WriteLine("Here's some info on that armor...\n{0}", item.FormatMe());
            Console.ReadLine();
        }
        public static void PrintFoodDetails(int itemID)
        {
            Console.Clear();


            string[] itemAttackRatingString = File.ReadAllLines("itemAttackRating.txt");
            int[] itemAttackRatingInt = itemAttackRatingString.Select(x => int.Parse(x)).ToArray();
            string[] itemDefenseRatingString = File.ReadAllLines("itemDefenseRating.txt");
            int[] itemDefenseRatingInt = itemDefenseRatingString.Select(x => int.Parse(x)).ToArray();
            string[] itemEffect = File.ReadAllLines("itemEffect.txt");
            string[] itemEnergyString = File.ReadAllLines("itemEnergy.txt");
            int[] itemEnergyInt = itemEnergyString.Select(x => int.Parse(x)).ToArray();
            string[] itemExpertisePenaltyString = File.ReadAllLines("itemExpertisePenalty.txt");
            int[] itemExpertisePenaltyInt = itemExpertisePenaltyString.Select(x => int.Parse(x)).ToArray();
            string[] itemlist = File.ReadAllLines("itemList.txt");
            string[] itemMovementPenaltyString = File.ReadAllLines("itemMovementPenalty.txt");
            int[] itemMovementPenaltyInt = itemMovementPenaltyString.Select(x => int.Parse(x)).ToArray();
            string[] itemPalitabilityString = File.ReadAllLines("itemPalitability.txt");
            int[] itemPalitabilityInt = itemPalitabilityString.Select(x => int.Parse(x)).ToArray();
            string[] itemQuality = File.ReadAllLines("itemQuality.txt");
            string[] itemType = File.ReadAllLines("itemType.txt");
            string[] itemValueString = File.ReadAllLines("itemValue.txt");
            int[] itemValueInt = itemValueString.Select(x => int.Parse(x)).ToArray();
            string[] itemWeightString = File.ReadAllLines("itemWeight.txt");
            int[] itemWeightInt = itemWeightString.Select(x => int.Parse(x)).ToArray();

            Item item = new Food
            {

                Name = itemlist[itemID],
                Value = itemValueInt[itemID],
                Weight = itemWeightInt[itemID],
                Quality = itemQuality[itemID],
                Palitability = itemPalitabilityInt[itemID],
                Energy = itemEnergyInt[itemID]
            };

            Console.WriteLine("Here's some info on that food...\n{0}", item.FormatMe());
            Console.ReadLine();
        }
        public static void PrintPotionDetails(int itemID)
        {
            Console.Clear();


            string[] itemAttackRatingString = File.ReadAllLines("itemAttackRating.txt");
            int[] itemAttackRatingInt = itemAttackRatingString.Select(x => int.Parse(x)).ToArray();
            string[] itemDefenseRatingString = File.ReadAllLines("itemDefenseRating.txt");
            int[] itemDefenseRatingInt = itemDefenseRatingString.Select(x => int.Parse(x)).ToArray();
            string[] itemEffect = File.ReadAllLines("itemEffect.txt");
            string[] itemEnergyString = File.ReadAllLines("itemEnergy.txt");
            int[] itemEnergyInt = itemEnergyString.Select(x => int.Parse(x)).ToArray();
            string[] itemExpertisePenaltyString = File.ReadAllLines("itemExpertisePenalty.txt");
            int[] itemExpertisePenaltyInt = itemExpertisePenaltyString.Select(x => int.Parse(x)).ToArray();
            string[] itemlist = File.ReadAllLines("itemList.txt");
            string[] itemMovementPenaltyString = File.ReadAllLines("itemMovementPenalty.txt");
            int[] itemMovementPenaltyInt = itemMovementPenaltyString.Select(x => int.Parse(x)).ToArray();
            string[] itemPalitabilityString = File.ReadAllLines("itemPalitability.txt");
            int[] itemPalitabilityInt = itemPalitabilityString.Select(x => int.Parse(x)).ToArray();
            string[] itemQuality = File.ReadAllLines("itemQuality.txt");
            string[] itemType = File.ReadAllLines("itemType.txt");
            string[] itemValueString = File.ReadAllLines("itemValue.txt");
            int[] itemValueInt = itemValueString.Select(x => int.Parse(x)).ToArray();
            string[] itemWeightString = File.ReadAllLines("itemWeight.txt");
            int[] itemWeightInt = itemWeightString.Select(x => int.Parse(x)).ToArray();

            Item item = new Potion
            {

                Name = itemlist[itemID],
                Value = itemValueInt[itemID],
                Weight = itemWeightInt[itemID],
                Quality = itemQuality[itemID],
                Palitability = itemPalitabilityInt[itemID],
                Energy = itemEnergyInt[itemID],
                Effect = itemEffect[itemID]
            };

            Console.WriteLine("Here's some info on that potion...\n{0}", item.FormatMe());
            Console.ReadLine();
        }
        public static void PrintWeaponDetails(int itemID)
        {
            Console.Clear();


            string[] itemAttackRatingString = File.ReadAllLines("itemAttackRating.txt");
            int[] itemAttackRatingInt = itemAttackRatingString.Select(x => int.Parse(x)).ToArray();
            string[] itemDefenseRatingString = File.ReadAllLines("itemDefenseRating.txt");
            int[] itemDefenseRatingInt = itemDefenseRatingString.Select(x => int.Parse(x)).ToArray();
            string[] itemEffect = File.ReadAllLines("itemEffect.txt");
            string[] itemEnergyString = File.ReadAllLines("itemEnergy.txt");
            int[] itemEnergyInt = itemEnergyString.Select(x => int.Parse(x)).ToArray();
            string[] itemExpertisePenaltyString = File.ReadAllLines("itemExpertisePenalty.txt");
            int[] itemExpertisePenaltyInt = itemExpertisePenaltyString.Select(x => int.Parse(x)).ToArray();
            string[] itemlist = File.ReadAllLines("itemList.txt");
            string[] itemMovementPenaltyString = File.ReadAllLines("itemMovementPenalty.txt");
            int[] itemMovementPenaltyInt = itemMovementPenaltyString.Select(x => int.Parse(x)).ToArray();
            string[] itemPalitabilityString = File.ReadAllLines("itemPalitability.txt");
            int[] itemPalitabilityInt = itemPalitabilityString.Select(x => int.Parse(x)).ToArray();
            string[] itemQuality = File.ReadAllLines("itemQuality.txt");
            string[] itemType = File.ReadAllLines("itemType.txt");
            string[] itemValueString = File.ReadAllLines("itemValue.txt");
            int[] itemValueInt = itemValueString.Select(x => int.Parse(x)).ToArray();
            string[] itemWeightString = File.ReadAllLines("itemWeight.txt");
            int[] itemWeightInt = itemWeightString.Select(x => int.Parse(x)).ToArray();

            Item item = new Weapon
            {

                Name = itemlist[itemID],
                Value = itemValueInt[itemID],
                Weight = itemWeightInt[itemID],
                Quality = itemQuality[itemID],
                Type = itemType[itemID],
                AttackRating = itemAttackRatingInt[itemID],
                ExpertisePenalty = itemExpertisePenaltyInt[itemID],
                Effect = itemEffect[itemID]
            };
            Console.WriteLine("Here's some info on that weapon...\n{0}", item.FormatMe());
            Console.ReadLine();
        }
    }

    public abstract class Item
    {
            public int ItemID { get; set; }
            public string Name { get; set; }
            public int Value { get; set; }
            public int Weight { get; set; }
            public string Quality { get; set; }

            public abstract string FormatMe();

    }
    public class Armor : Item
    {
        public string Type { get; set; }
        public int DefenseRating { get; set; }
        public int MovementPenalty { get; set; }
        public string Effect { get; set; }

        public override string FormatMe()
        {
            if( Effect == "-1")
            return String.Format("Name - {0}\nValue - {1} Kir\nWeight - {2} Oz\nQuality - {3}\nType" +
                " - {4}\nDefense Rating - {5}\nMovement Penalty - {6}%", Name, Value, Weight, Quality, Type, DefenseRating, MovementPenalty);
            return String.Format("Name - {0}\nValue - {1} Kir\nWeight - {2} Oz\nQuality - {3}\nType" +
                " - {4}\nDefense Rating - {5}\nMovement Penalty - {6}%\nEffect - {7}", Name, Value, Weight, Quality, Type, DefenseRating, MovementPenalty, Effect);
        }
    }
    public class Food : Item
    {
        public int Palitability { get; set; }
        public int Energy { get; set; }

        public override string FormatMe()
        {
            return String.Format("Name - {0}\nValue {1} Kir\nWeight - {2} Oz\nQuality - {3}\nPalitability" +
                " - {4}\nEnergy - {5}", Name, Value, Weight, Quality, Palitability, Energy);
        }
    }
    public class Potion : Food
    {
        public string Effect { get; set; }
           
        public override string FormatMe()
        {
            return String.Format("Name - {0}\nValue {1} Kir\nWeight - {2} Oz\nQuality - {3}\nPalitability" +
                " - {4}\nEngergy - {5}\nEffect - {6}", Name, Value, Weight, Quality, Palitability, Energy, Effect);
        }
    }
    public class Weapon : Item
    {
        public string Type { get; set; }
        public int AttackRating { get; set; }
        public int ExpertisePenalty { get; set; }
        public string Effect { get; set; }

        public override string FormatMe()
        {
            if (Effect == "-1")
            return String.Format("Name - {0}\nValue {1} Kir\nWeight - {2} Oz\nQuality - {3}\nType - " +
                "{4}\nAttack Rating - {5}\nExpertise Penalty - {6}% Damage Reduction", 
                Name, Value, Weight, Quality, Type, AttackRating, ExpertisePenalty);
            else
                return String.Format("Name - {0}\nValue {1} Kir\nWeight - {2} Oz\nQuality - {3}\nType - " +
                "{4}\nAttack Rating - {5}\nExpertise Penalty - {6}% Damage Reduction\nEffect - {7}",
                Name, Value, Weight, Quality, Type, AttackRating, ExpertisePenalty, Effect);
        }

    }
}
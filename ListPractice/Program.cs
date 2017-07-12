using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7);
            //favNumbers.Add(69); //<---- adding later on
            //favNumbers.Add(99);

            //foreach (int number in favNumbers)
            //{
            //    Console.WriteLine(number); //<--- numbers of the list
            //}
            //Console.WriteLine(favNumbers.Count); //<--- size of list .Count



            //List<string> books = new List<string> { "Cat in the Hat", "Toad and Frog", "Green Eggs and Ham" };
            //Console.WriteLine(books[0]);
            //books.Insert(0, "Horton Hears a Who");   // 0, means adding to list. (index 0) // .Insert means at the current index, moving previous element down.
            //Console.WriteLine(books[0]);



            //// Create a List and add 5 animals using .Add();
            //// Print each animals in the list

            //List<string> favAnimals = new List<string>();
            //favAnimals.Add("Panda");
            //favAnimals.Add("Otter");
            //favAnimals.Add("Kanagroo");
            //favAnimals.Add("Giraffe");
            //favAnimals.Add("Lion");

            //foreach (string animals in favAnimals)
            //{
            //    Console.WriteLine(animals);
            //}


            //// Create the following list:
            //// A bool list should contatin {true, false, true, false}
            //// Loop through each value
            //// - if value is true print "Better bring an umbrella."
            //// - if valuse is false print "No rain today enjoy the sun." 

            //List<bool> trueFalse = new List<bool> { true, false, true, false };

            //foreach (bool TF in trueFalse)
            //{
            //    if(TF == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today enjoy the sun.");
            //    }
            //}

            //// Another example with FOR Loop 
            ////for (int i = 0; i < trueFalse.Count; i++)
            ////{
            ////    if (trueFalse[i] == true)
            ////    {
            ////        Console.WriteLine("Better bring an umbrella.");
            ////    }
            ////    else
            ////    { 
            ////        Console.WriteLine("No rain today enjoy the sun.");
            ////    }
            ////}

            //List<string> favFood = new List<string> { "Steak", "Sushi", "Fries", "Thai", "Tacos" };

            //if(favFood.Contains("Fish"))
            //{
            //    Console.WriteLine("I like fish too!");
            //}


            //// Create a list with the following numbers: 1 23 9 77 922 6 32 63 14 5
            //// use the contains method with the following values: 23 77 15
            //// Remove these elements: 23 77 32 6
            //// Use .Contains() again on these value: 23 77 15

            //List<int> randomNumbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //Console.WriteLine(randomNumbers.Contains(23));
            //Console.WriteLine(randomNumbers.Contains(77));
            //Console.WriteLine(randomNumbers.Contains(15));

            //randomNumbers.Remove(23);
            //randomNumbers.Remove(77);
            //randomNumbers.Remove(32);
            //randomNumbers.Remove(6);

            //Console.WriteLine(randomNumbers.Contains(23));
            //Console.WriteLine(randomNumbers.Contains(77));
            //Console.WriteLine(randomNumbers.Contains(15));


            // Set up a Movie Ordering Service. 
            // - Ask user for a movie 
            //   - if movie in not on list .Add it
            // Inform the user that the movie has been added.
            // If movie is on the list, let them know that movie is on the way.
            // If user enters "quit" the program should exit. 
            // The users should be able to add as many movies as they want

            List<string> orderMovies = new List<string> {"We Are Your Friends", "White Chicks", "Super Trooper", "Donnie Darko", "WALL-E",};

            Console.WriteLine("What movies would you like to order today?");
            string renter = Console.ReadLine();
            

            //do <--- for quitting
            //{
                if (orderMovies.Contains(renter))
                {

                    Console.WriteLine("Good choice! Your movie is on the way.");
                }
                else 
                {
                    Console.WriteLine("Sorry we're out of stock, well add it right away!");
                    orderMovies.Add(renter);
                    Console.WriteLine("We have added {0} to the list.", renter);
                }
            //}
            


           





        }
    }
}

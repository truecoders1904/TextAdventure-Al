using System;

namespace AlTextAdventure
{
    class Program
    {

      static void Main(string[] args)

        {
            Console.WriteLine("Hi!");
            Console.WriteLine("Welcome to The Bar!");
            Console.WriteLine("Would you like a table?");

            string response = Console.ReadLine();

            if (response == "Yes")
            {
                Console.WriteLine("Great! Would you like a drink?");
                response = Console.ReadLine();

                if (response == "Yes")
                {
                    Console.WriteLine("Fantastic, here you go!");
                    Console.WriteLine("Are you up for a game of beer pong?");
                    response = Console.ReadLine();

                    if (response == "Yes")
                    {
                        Console.WriteLine("Awesome, let's do this!");
                        Console.WriteLine("You ready for this L?");
                        response = Console.ReadLine();

                        if (response == "Yes")
                        {
                            Console.WriteLine("Haha. Loser! *laughs in spanish*");
                        }
                        else
                        {
                            Console.WriteLine("K.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You scared, bro?");
                        response = Console.ReadLine();

                        if (response == "Yes")
                        {
                            Console.WriteLine("Fine. You get a pass this time!");
                        }
                        else
                        {
                            Console.WriteLine("Ha. Whimp! *laughs in spanish*");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ok, you need to get out! *angry voice*");
                }
            }
            else
            {
                Console.WriteLine("Wow. Get out. This area is for customers only! *annoyed voice*");

            }
        }
    }
}
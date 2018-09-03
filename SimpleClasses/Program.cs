using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // new command uses the class pattern in memory to be usable by the application
            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlass Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}", 
            myCar.Make, 
            myCar.Model, 
            myCar.Year, 
            myCar.Color);

            decimal value = DetermineMarketValue(myCar);
            Console.WriteLine(value);


            Console.ReadLine();

        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.00M;
            //Someday I might look up the car online
            //to get a more accurate value

            return carValue;
        }
    }

    class Car
    {

        //Use the shortcut "prop" in intellisense and then hit Tab-Tab for the below.
        //Another option would be propfull for more complete properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


    }

}

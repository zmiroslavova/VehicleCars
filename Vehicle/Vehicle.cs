using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public int passengers;
        public int fuelCap;
        public int fuelConsum;
        public double litersMinivan;
        public double litersSportsCar;

        public int Range()
        {
            return fuelCap * fuelConsum;
        }

        public double FuelNeeded(double kilometers)
        {
            return (kilometers/100) * fuelConsum;
        }
    }

    class VehicleDemo
    {
        public static void Main(string[] args)
        {
        
            Vehicle minivan = new Vehicle();
            Vehicle sportsCar = new Vehicle();
                                                          
            Console.Write("Please input number passengers on minivan: ");
            minivan.passengers = int.Parse(Console.ReadLine());
            Console.Write("Please input fuel capacity on minivan: ");
            minivan.fuelCap = int.Parse(Console.ReadLine());
            Console.Write("Please input fuel consummation on minivan for 100 km: ");
            minivan.fuelConsum = int.Parse(Console.ReadLine());

            Console.Write("Please input number passengers on sports car: ");
            sportsCar.passengers = int.Parse(Console.ReadLine());
            Console.Write("Please input fuel capacity on sports car: ");
            sportsCar.fuelCap = int.Parse(Console.ReadLine());
            Console.Write("Please input fuel consummation on sports car for 100 km: ");
            sportsCar.fuelConsum = int.Parse(Console.ReadLine());

            Console.WriteLine($"Minivan can carry {minivan.passengers} passengers with range of {minivan.Range()} kilometers.");            
            Console.WriteLine($"Sports car can carry {sportsCar.passengers} passengers with range of {sportsCar.Range()} kilometers.");

            Console.Write("Plase input how many kilometers you want to drive with minivan and sports car: ");
            double kilometers = int.Parse(Console.ReadLine());
            
            minivan.litersMinivan = minivan.FuelNeeded(kilometers);
            sportsCar.litersSportsCar = sportsCar.FuelNeeded(kilometers);

            Console.WriteLine($"To go {kilometers} kilometers minivan needs {minivan.litersMinivan} liters.");
            Console.WriteLine($"To go {kilometers} kilometers sports car needs {sportsCar.litersSportsCar} liters.");

            if (minivan.litersMinivan < sportsCar.litersSportsCar)
            {
                Console.WriteLine($"Minivan is more economical than the sports car for these {kilometers} kilometers.");
            }
            else
            {
                Console.WriteLine($"Sports car is more economical than the minivan for these {kilometers} kilometers.");
            }
       
            Console.ReadKey();
        }
             
    }
 
}

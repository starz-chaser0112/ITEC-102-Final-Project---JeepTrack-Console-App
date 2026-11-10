using System;
class Jeeptrack
{
    static void Main()
    {
        // Methods

        // Welcoming Message
        static void WelcomeMessage()
        {
            Console.WriteLine("===================== Welcome to JeepTrack! =====================");
        }

        // Available Locations
        static void DisplayLocations()
        {
            Console.WriteLine("                 ----- Available Locations -----\n");
            Console.WriteLine("> San Pablo City \t\t\t > SM San Pablo");
            Console.WriteLine("> LSPU-San Pablo City Campus \t\t > Liliw");
            Console.WriteLine("> Nagcarlan \t\t\t\t > Tiaong");
            Console.WriteLine("> Calauan \t\t\t\t > Los Banos");
            Console.WriteLine("> Sta Cruz");
        }

        // Main Program

        // Display Welcome Message
        WelcomeMessage();
        
            string[] locations = {"SAN PABLO CITY", "SM SAN PABLO", "LSPU-SAN PABLO CITY CAMPUS", "LILIW", "NAGCARLAN", "TIAONG", "CALAUAN", "LOS BANOS", "STA CRUZ"};
            string currentLocation = " ";
            string destination = " ";
        // Current Location 
        

        while (true)
        {
            // Display Available Locations
            Console.WriteLine();
            DisplayLocations();
            Console.WriteLine();
            
            // Input Current Location
            Console.Write("Enter your current location (enter \"exit\" to quit): ");
            currentLocation = Console.ReadLine().ToUpper();
            Console.WriteLine();

            // Location Validation
            bool locationFound = false;

            for(int i = 0; i < locations.Length; i++)
            {
                if(currentLocation == locations[i])
                {
                    locationFound = true;
                    break;
                }

                else if(currentLocation.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the program...");
                    return;
                }
            }

            if(locationFound)
            {
                break;
            }              
            Console.WriteLine("\t\t ----- LOCATION NOT FOUND! -----");
        }

        //Destination
        while (true)
        {
            // Display Available Locations
            Console.WriteLine();
            DisplayLocations();
            Console.WriteLine();

            // Input Destination
            Console.Write("Enter your destination (enter \"exit\" to quit): ");
            destination = Console.ReadLine().ToUpper();
            Console.WriteLine();

            // Location Validation

            bool locationFound = false;

            for(int i = 0; i < locations.Length; i++)
            {
                if(destination == locations[i])
                {
                    locationFound = true;
                    break;
                }

                else if(destination.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the program...");
                    return;
                }                
            }
        
            if(locationFound)
            {
                break;
            }              
            Console.WriteLine("/t/t/t ----- LOCATION NOT FOUND! -----");
        }
        
        // Validating Route
        string routes = currentLocation + ("-") + destination;
        double travelDistance = 0;
        double timeTravel = 0;

        switch (routes)
        {
            case "SAN PABLO CITY-SM SAN PABLO":
            case "SM SAN PABLO-SAN PABLO CITY":
                travelDistance = 2.9;
                timeTravel = 9;
            break;

            case "SAN PABLO CITY-LSPU-SAN PABLO CITY CAMPUS":
            case "LSPU-SAN PABLO CITY CAMPUS-SAN PABLO CITY":
                travelDistance = 2.9;
                timeTravel = 11;
            break;

            case "SAN PABLO CITY-LILIW":
            case "LILIW-SAN PABLO CITY":
                travelDistance = 19.8;
                timeTravel = 46;
            break;

            case "SAN PABLO CITY-NAGCARLAN":
            case "NAGCARLAN-SAN PABLO CITY":
                travelDistance = 15.8;
                timeTravel = 37;
            break;

            case "SAN PABLO CITY-TIAONG":
            case "TIAONG-SAN PABLO CITY":
                travelDistance = 13.1;
                timeTravel = 24;
            break;

            case "LSPU-SAN PABLO CITY CAMPUS-CALAUAN":
            case "CALAUAN-LSPU-SAN PABLO CITY CAMPUS":
                travelDistance = 8.3;
                timeTravel = 15;
            break;

            case "LSPU-SAN PABLO CITY CAMPUS-LOS BANOS":
            case "LOS BANOS-LSPU-SAN PABLO CITY CAMPUS":
                travelDistance = 20.7;
                timeTravel = 40;
            break;

            case "SAN PABLO CITY-STA CRUZ":
            case "STA CRUZ-SAN PABLO CITY":
                travelDistance= 30;
                timeTravel = 60;
            break;

            case "NAGCARLAN-LILIW":
            case "LILIW-NAGCARLAN":
                travelDistance= 3.2;
                timeTravel = 9;
            break;

            case "NAGCARLAN-STA CRUZ":
            case "STA CRUZ-NAGCARLAN":
                travelDistance = 17;
                timeTravel = 38;
            break;

            default:
                Console.WriteLine("\t\t ----- ROUTE NOT FOUND! -----");
                Console.WriteLine();
                return;
            break;
        }

        // Passenger Type
        string[] passengerTypes = {"REGULAR", "SENIOR CITIZEN", "PWD", "STUDENT"};
        string passengerType = " ";

        double initialDistance = 4;
        double initialRate = 14.00;
        double succeedingRate = 2;
        double finalFare = 0;
        double discount = 0.20;
        double discountedFare = 0;

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("                 ----- Passenger Type -----\n");
            Console.Write("Enter passenger type (Regular, Senior Citizen, PWD, Student): ");
            passengerType = Console.ReadLine().ToUpper();

            bool validPassenger = false; 

            for(int i = 0; i < passengerTypes.Length; i++)
            {
                if(passengerType == passengerTypes[i])
                {
                    validPassenger = true;
                    break;
                }
            }

            if(validPassenger)
            {
                break;
            }
                Console.WriteLine("Invalid passenger type. Please enter a valid type.");

            // Fare Calculation

            
        }

        double fare = (travelDistance - initialDistance) * succeedingRate + initialRate;
                if (passengerType == "REGULAR")
                {
                    discount = 0;
                    finalFare = fare;
                }
                else {
                    discountedFare = fare * discount;
                    finalFare = fare - discountedFare;
                } 

        // Travel Information
        Console.WriteLine();
        Console.WriteLine("=========================== JEEPTRACK ===========================");
        Console.WriteLine("\t\t\t----- ROUTE -----");
        Console.WriteLine($"[ {currentLocation} > {destination} ]");
        Console.WriteLine($"DISTANCE \t\t\t\t\t EST TRAVEL TIME");
        Console.WriteLine($"> {travelDistance:F1} km < \t\t\t\t\t > {timeTravel:F1} minutes <");
        Console.WriteLine("_________________________________________________________________");
        Console.WriteLine("\t\t    ----- PASSENGER TYPE -----");    
        Console.WriteLine($"PASSENGER TYPE \t\t\t\t\t DISCOUNT");                            
        Console.WriteLine($"> {passengerType} <\t\t\t\t\t > {discount:P1} < ");
        Console.WriteLine("_________________________________________________________________");
        Console.WriteLine("\t\t\t----- FARE -----");
        Console.WriteLine($"BOUND TO: {currentLocation} > {destination}\nFARE AMOUNT: ₱ {finalFare:F2}");
        Console.WriteLine("===================== Have a Safe Journey! ======================");
    }
}

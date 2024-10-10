using System.Globalization;

namespace ClassExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            /*
            var petOne = new Pet();
            petOne.Name = "  shadow   ";
            petOne.Species = "cat";
            petOne.Age = 3;

            var petTwo = new Pet();
            petTwo.Name = "  buddy   ";
            petTwo.Species = "dog";
            petOne.Age = 5;

            Console.WriteLine("Pet One:  " + petOne.Name + " " + petOne.Species + " " + petOne.Age);
            Console.WriteLine("Pet Two:  " + petTwo.Name + " " + petTwo.Species + " " + petOne.Age);
        */

            //Example 2
            var pets = new List<Pet>
            {
                new Pet { Name = "shadow", Species = "cat", Age = 5, Price = 200.00, Color = "Black" },
                new Pet { Name = "shadow", Species = "dog", Age = 3, Price = 500.00, Color = "Black" },
                new Pet { Name = "buddy", Species = "dog", Age = 5, Price = 450.00, Color = "Brown" },
                new Pet { Name = "rex", Species = "dog", Age = 2, Price = 300.00, Color = "Golden" },
                new Pet { Name = "whiskers", Species = "cat", Age = 4, Price = 150.00, Color = "White" },
                new Pet { Name = "mittens", Species = "cat", Age = 3, Price = 200.00, Color = "Grey" },
                new Pet { Name = "tiger", Species = "cat", Age = 6, Price = 250.00, Color = "Orange" }
            };

            Console.WriteLine("All Pets:");
            foreach (var pet in pets)
            {
                Console.WriteLine("\tName: " + pet.Name + "\tSpecies: " + pet.Species + "\tAge: " + pet.Age + "\tPrice: " + pet.Price + "\tColor: " + pet.Color);
            }

            Console.WriteLine("\nDogs:");
            var dogs = pets.Where(pet => pet.Species == "dog").ToList();

            foreach (var dog in dogs)
            {
                Console.WriteLine("\tName: " + dog.Name + "\tSpecies: " + dog.Species + "\tAge: " + dog.Age + "\tPrice: " + dog.Price + "\tColor: " + dog.Color);
            }

            Console.WriteLine("\nCats:");
            var cats = pets.Where(pet => pet.Species == "cat").ToList();

            foreach (var cat in cats)
            {
                Console.WriteLine("\tName: " + cat.Name + "\tSpecies: " + cat.Species + "\tAge: " + cat.Age + "\tPrice: " + cat.Price + "\tColor: " + cat.Color);
            }

            Console.WriteLine("\nJust Animal With The Name Buddy:");
            var buddy = pets.Find(pet => pet.Name.ToLower().Trim() == "buddy");
            Console.WriteLine("\tName: " + buddy.Name + "\t" + buddy.Species + "\t" + buddy.Age + "\t" + buddy.Price + "\t" + buddy.Color);

            Console.WriteLine("\nJust Animals With The Name Shadow:");
            var shadows = pets.FindAll(pet => pet.Name.ToLower().Trim() == "shadow");
            
            foreach (var shadow in shadows)
            {
                Console.WriteLine("\tName: " + shadow.Name + "\tSpecies: " + shadow.Species + "\tAge: " + shadow.Age + "\tPrice: " + shadow.Price + "\tColor: " + shadow.Color);
            }
        }

        public class Pet
        {
            private string name;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value).Trim();
                }
            }

            public string Species;
            public int Age;
            public double Price;
            public string Color;
        }

    }
}

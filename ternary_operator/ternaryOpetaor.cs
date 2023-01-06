class Program
{
    static void Main(string[] args)
    {
        //create a bool for our operator
        bool kodParol;

        //create two variables
        // 1 - with "true" word
        string storedPassword = "swordfish";

        // 2 - with a word from person
        string entPassword = Console.ReadLine();

        //condition, where we use ternary operator 
        kodParol = entPassword == storedPassword ? true : false;

        //bool output
        Console.WriteLine(kodParol);
        
    
        Console.ReadLine();
    }
}
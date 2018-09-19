using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initial Card Deck in string array.
            string[,] card_deck = 
            {
                {"S_A", "H_A", "C_A", "D_A"},
                {"S_2", "H_2", "C_2", "D_2"},
                {"S_3", "H_3", "C_3", "D_3"},
                {"S_4", "H_4", "C_4", "D_4"},
                {"S_5", "H_5", "C_5", "D_5"},
                {"S_6", "H_6", "C_6", "D_6"},
                {"S_7", "H_7", "C_7", "D_7"},
                {"S_8", "H_8", "C_8", "D_8"},
                {"S_9", "H_9", "C_9", "D_9"},
                {"S_10", "H_10", "C_10", "D_10"},
                {"S_J", "H_J", "C_J", "D_J"},
                {"S_Q", "H_Q", "C_Q", "D_Q"},
                {"S_K", "H_K", "C_K", "D_K"},
            };

            // Shuffles card_deck using function Shuffle.
            Random rnd = new Random();
            Shuffle(rnd, card_deck);

            // Outputs the shuffled card_deck in both dimensions.
            for (int i = 0; i < card_deck.GetLength(0); i++)
            {
                for (int j = 0; j < card_deck.GetLength(1); j++)
                {
                    Console.WriteLine(card_deck[i, j]);
                }
            }

            // Wait.
            Console.ReadLine(); 
        }

        // Function to shuffle in two dimenions.
        public static void Shuffle<T>(Random random, T[,] array)
        {
            int lengthRow = array.GetLength(1);

            for (int i = array.Length - 1; i > 0; i--)
            {
                int i0 = i / lengthRow;
                int i1 = i % lengthRow;

                int j = random.Next(i + 1);
                int j0 = j / lengthRow;
                int j1 = j % lengthRow;

                T temp = array[i0, i1];
                array[i0, i1] = array[j0, j1];
                array[j0, j1] = temp;
            }
        }
    }
}
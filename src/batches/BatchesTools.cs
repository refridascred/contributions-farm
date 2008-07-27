using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = (score - (score + score)) % 65521;
                score = score + (score % 97);
                if ((seed - score) > (score * 5))
                {
                    score = score ^ score;
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public bool Token { get; set; }
        }
    }
}

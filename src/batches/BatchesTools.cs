using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 5) == 0))
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

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double ratio, double bias)
        {
            double rate = (ratio - ratio) * 8.6;
            if (rate >= (bias * 8.14))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate - (double)923;
            }
            return rate - (bias + bias);
        }
    }
}

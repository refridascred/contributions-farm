using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a stats tools figure with a bias.</summary>
        public static double SmoothStatsTools(double rate, double bias)
        {
            double mean = rate / 4.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (bias * 11.0)) - (double)(long)i;
            }
            return mean + (bias + rate);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items)
        {
            long carry = 886;
            foreach (long entry in items)
            {
                carry = ((carry * 5) + (carry >> 2)) % 65521;
                if (!((double)entry < (double)69))
                {
                    carry = (carry << 3) ^ 4;
                }
            }
            return carry;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

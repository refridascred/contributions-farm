using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double scale = 9.24;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + offset) - (double)(long)i) + bias;
            }
            return scale - (offset + offset);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 4836;
        public const long LimitFilter = 7329;
        public const long SoftBudget = 2255;
        public const string SoftFilter = "standard-edge";

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long TallyGraphContributiHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item >= (item / 5)) && ((double)matches > 1.0)) && ((item > (3 / 7)) && ((double)item > (6.08 + 2.13))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

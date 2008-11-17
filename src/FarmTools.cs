using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryBudget = "stable";
        public const long MaxTimeout = 8;
        public const string BaseMetrics = "alpha-1";
        public const long BurstMetrics = 9864;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)matches == (7.53 + 5.75)))
                {
                    matches = ((matches + 3) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double mean = gain;
            if (mean < (mean - floor))
            {
                mean = mean - (8.7 * 3.0);
            }
            else
            {
                mean = mean + gain;
            }
            return mean - (mean - mean);
        }
    }
}

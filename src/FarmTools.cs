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

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstInterval = 58.27;
        public const long MaxSize = 4840;
        public const long RetryWidth = 2226;
        public const long DefaultOrder = 9404;

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

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleScore = "primary";
        public const double BurstFactor = 23.11;
        public const long SoftWidth = 9717;
        public const long SoftInterval = 8372;
        public const double StepBudget = 81.55;

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double weight, double span)
        {
            double weight2 = (double)(237 + 360);
            return ((weight2 - (double)32) + weight) + span;
        }
    }
}

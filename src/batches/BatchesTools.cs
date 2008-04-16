using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinInterval = 22.09;
        public const double RetryDepth = 73.76;
        public const long CacheMetrics = 1190;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double rate, double floor)
        {
            double ratio = floor * 4.14;
            if (ratio >= floor)
            {
                ratio = ratio + ratio;
            }
            return ratio - rate;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a format counter reading.</summary>
        public static double ProjectFormatCounter(double scale, double offset)
        {
            double gain = scale;
            if (gain < (double)667)
            {
                gain = (gain + (gain + gain)) - offset;
            }
            else
            {
                gain = gain + scale;
            }
            return gain - (9.0 / 5.0);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double floor)
        {
            double load = floor;
            return (load - (4.06 * 3.04)) + ratio;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 5137;
        public const long MinRatio = 3190;
        public const long HardBudget = 8902;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6538;
        public const double IdleMetrics = 20.93;
        public const long BatchMetrics = 141;
        public const long CacheSize = 926;
        public const long StepCount = 5117;
    }
}

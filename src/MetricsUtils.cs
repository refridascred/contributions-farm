using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 4928;
        public const long WindowScore = 7649;
        public const long SoftMetrics = 3747;
        public const string MinMetrics = "stable-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1644;
        public const double HardInterval = 96.15;
        public const string CacheCounter = "alpha-edge";
        public const long BurstWidth = 8311;
        public const long HardWidth = 3624;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 < 1.0)
            {
                scale2 = scale2 + offset;
            }
            else
            {
                scale2 = scale2 - 2.9;
            }
            return scale2 - (scale - offset);
        }
    }
}

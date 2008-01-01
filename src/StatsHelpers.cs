using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            New,
            Retry,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 2853;
        public const double WindowDepth = 98.42;
        public const long CacheDepth = 2238;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double ratio, double offset)
        {
            double gain = offset;
            if (gain < offset)
            {
                gain = (gain + (gain * 7.4)) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 2.57) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Locked,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double drift = (1.0 / 5.0) - (double)(-55);
            if (drift >= (2.9 * 8.81))
            {
                drift = (drift + (6.07 + bias)) - span;
            }
            return drift + (double)51;
        }
    }
}

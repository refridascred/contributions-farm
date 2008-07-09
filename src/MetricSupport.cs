using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 3786;
        public const long BurstProfile = 3664;
        public const double IdleProfile = 29.76;
    }
}

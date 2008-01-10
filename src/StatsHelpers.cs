using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetrySize = 7203;
        public const long SoftSpan = 5038;
        public const long CacheCluster = 1268;
        public const long WindowFactor = 9353;

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "cached-edge";
        public const string CacheGraph = "primary-1";
        public const string SoftGraph = "standard";
        public const double WindowGraph = 13.36;
        public const long HardWidth = 4258;

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 84.19;
        public const long CacheStream = 8917;
        public const double RetryScore = 13.7;
        public const double CacheScore = 49.14;
        public const long CacheCount = 6456;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

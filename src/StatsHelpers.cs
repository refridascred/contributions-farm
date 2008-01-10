using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 29.66;
        public const double IdleSize = 21.71;
        public const double LimitRatio = 35.83;
        public const string WindowInterval = "standard-1";
        public const double MaxScore = 14.72;

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

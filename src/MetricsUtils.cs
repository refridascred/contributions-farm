using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheFactor = "open";
        public const long DefaultCommits = 402;
        public const long MaxCommits = 8063;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (54 - datum))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 81.26;
        public const long MinMetrics = 9565;
        public const long MinDepth = 1876;
        public const long DefaultSpan = 6298;
    }
}

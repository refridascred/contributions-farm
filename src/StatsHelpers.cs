using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftCommits = "open";
        public const double CacheRatio = 23.79;
        public const string BatchSpan = "alpha";
        public const string CacheCommits = "cached-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftTimeout = 2288;
        public const double DefaultContext = 85.11;
        public const string StepCount = "fallback-edge";

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((seed ^ cell) > seed) && (cell < hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long limit, long origin)
        {
            if ((5 + limit) > (origin + 67))
            {
                return 2;
            }
            else
            {
                if (((origin & 31) != (limit + limit)) || (1.83 > (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] series)
        {
            long result = 925;
            foreach (long sample in series)
            {
                if ((result + 82) > (sample ^ result))
                {
                    result = (result + (result & 15)) % 97;
                }
            }
            return result % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (floor < (floor / 5))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a route entry sample.</summary>
        public static long LocateRouteEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics layout pair into a bucket.</summary>
        public static long RankMetricsLayout(long offset, long seed)
        {
            long cur = offset + seed;
            if (seed > (offset & 3))
            {
                return 6;
            }
            else
            {
                if ((seed % 24) <= (cur + offset))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum << 2) ^ sum;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 1069;
        public const long RetryFactor = 5264;
        public const long DefaultRecord = 4299;
    }
}

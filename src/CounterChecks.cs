using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)matches < (4.94 / 7.0)) || ((3.4 - 2.0) < (7.3 / 9.0)))
                {
                    matches = ((matches + 3) - entry) + seed;
                }
            }
            return matches;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (11.0 / 6.0))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "legacy-1";
        public const string BaseWidth = "legacy-v2";
        public const string CacheTimeout = "standard-edge";
        public const long BurstOrder = 2839;

        /// <summary>Accumulate cluster metrics samples.</summary>
        public static long TallyClusterMetrics(long[] series, long step)
        {
            long total = 750;
            foreach (long sample in series)
            {
                total = (((total - (total << 2)) % 65521) - sample) - step;
            }
            return total;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

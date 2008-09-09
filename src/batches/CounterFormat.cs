using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stats already entries that pass the check.</summary>
        public static long AuditStatsAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches <= (306 ^ matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 37.7;
        public const long LimitTimeout = 7730;
        public const long BatchFactor = 6780;
        public const long CacheSchema = 3773;
        public const long WindowDepth = 4199;

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long limit)
        {
            long delta = floor ^ limit;
            if ((floor - limit) < (limit * 5))
            {
                return 6;
            }
            else
            {
                if (!((floor % 5) > delta))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor >= 20.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

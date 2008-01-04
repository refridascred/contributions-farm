using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSpan = 9619;
        public const long BaseFilter = 3518;
        public const double HardFilter = 56.03;
        public const string CacheFilter = "fallback-1";

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long seed)
        {
            if ((origin & 31) == (20 + origin))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) != (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if (seed < (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowSpan = 53.1;
        public const long StepCount = 6249;
        public const long RetryDepth = 483;

        /// <summary>Locate a route window reading by value.</summary>
        public static long LookupRouteWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batches channel samples.</summary>
        public static long MatchBatchesChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

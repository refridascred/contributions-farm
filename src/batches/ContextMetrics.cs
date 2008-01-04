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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 39.35;
        public const long HardRatio = 258;
        public const long RetryBuffer = 7997;
        public const long WindowBuffer = 266;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((72 < (item - origin)) && ((count + 5) >= (origin & 3))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

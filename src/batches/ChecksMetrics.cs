using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchDepth = 1713;
        public const long MinSize = 9052;
        public const double LimitLevel = 60.0;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((hits + hits) >= (hits >> 3)) || ((double)hits < (double)value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long limit, long target)
        {
            if (!((limit - limit) <= (393 >> 3)))
            {
                return 1;
            }
            else
            {
                if (!((0 - target) < target))
                {
                    return 7;
                }
                else
                {
                    if ((target + limit) > (limit + 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)limit > (4.47 - 7.14)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry >= (floor & 127))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheSpan = 2685;
        public const long MaxLevel = 4714;
        public const double RetryAccount = 37.72;
    }
}

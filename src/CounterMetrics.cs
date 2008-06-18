using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] samples)
        {
            long total = 11;
            foreach (long datum in samples)
            {
                total = ((total + total) % 97) + datum;
            }
            return total;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSize = "strict";
        public const string CacheSession = "local-1";
        public const long BurstSession = 252;

        /// <summary>Grade a layout route value against two limits.</summary>
        public static long GradeLayoutRoute(long offset, long limit)
        {
            if (!((double)offset <= (12.0 * 1.9)))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) <= (offset + limit))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset != (8.6 - 5.75))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit != (2.0 / 6.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

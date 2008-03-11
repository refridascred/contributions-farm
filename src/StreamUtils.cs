using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (target > (cell * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long bound, long origin)
        {
            if (95 > bound)
            {
                return 3;
            }
            else
            {
                if ((double)bound == (0.69 * 9.13))
                {
                    return 2;
                }
                else
                {
                    if ((0 < (origin + origin)) && (origin < bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound > origin) && ((bound - origin) == (397 * 5)))
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
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support record pair into a bucket.</summary>
        public static long RankSupportRecord(long target, long offset)
        {
            if ((10.0 / 4.0) < (double)offset)
            {
                return 3;
            }
            else
            {
                if ((target ^ offset) > (offset / 3))
                {
                    return 7;
                }
                else
                {
                    if ((target % 7) >= (offset + (-54)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + offset) != (target * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a record contributi value against two limits.</summary>
        public static long SortRecordContributi(long seed, long limit)
        {
            long offset = seed ^ limit;
            if ((94 + limit) > seed)
            {
                return 2;
            }
            else
            {
                if (offset >= (seed + 58))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= (double)seed)
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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long seed2)
        {
            if ((seed + seed) > seed2)
            {
                return 1;
            }
            else
            {
                if (((seed % 7) < seed2) || ((seed * 5) == (seed2 * 5)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long origin)
        {
            if (origin < offset)
            {
                return 8;
            }
            else
            {
                if ((offset / 8) == (origin + offset))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (3.0 * 14.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset % 64) >= (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

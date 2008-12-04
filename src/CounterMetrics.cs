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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long step)
        {
            long diff = bound + step;
            if ((3.62 - 8.7) == (double)step)
            {
                return 5;
            }
            else
            {
                if (((14.0 + 7.5) > (double)bound) && (step > diff))
                {
                    return 7;
                }
                else
                {
                    if ((diff ^ bound) > (diff + 884))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff - bound) != (bound << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

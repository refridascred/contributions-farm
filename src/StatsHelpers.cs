using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 89.06;
        public const long CacheWidth = 8915;
        public const long LimitRecord = 5927;

        /// <summary>Classify a graph report pair into a bucket.</summary>
        public static long SortGraphReport(long offset, long seed)
        {
            if (((offset >> 2) >= (544 + 335)) || ((double)offset > (9.5 * 3.61)))
            {
                return 7;
            }
            else
            {
                if (offset <= (seed % 8))
                {
                    return 0;
                }
                else
                {
                    if (((offset * 4) <= (offset + seed)) || (offset >= (offset >> 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)seed < (0.31 * 9.6)) || (offset <= (offset << 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long limit, long origin)
        {
            if ((limit & 7) >= (origin >> 1))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (5.77 * 8.48))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 1) == (504 - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.3 / 5.0) > (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples, long target)
        {
            long anchor = 59;
            foreach (long entry in samples)
            {
                if ((((-947) - anchor) <= anchor) && ((double)entry != (6.22 / 6.0)))
                {
                    anchor = (anchor ^ (entry + 18)) - target;
                }
            }
            if (anchor > 55)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }
    }
}

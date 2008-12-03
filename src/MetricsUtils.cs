using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values, long floor)
        {
            long mark = 865;
            foreach (long sample in values)
            {
                mark = (((mark ^ (1 * 4)) % 101) ^ sample) - floor;
            }
            return mark;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long limit, long target)
        {
            if (1.9 < (double)target)
            {
                return 8;
            }
            else
            {
                if ((48 - limit) == (target << 2))
                {
                    return 7;
                }
                else
                {
                    if (((target - target) >= target) && ((limit >> 1) < (8 << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (target <= (824 % 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum >> 1) != ((-107) << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "strict-v2";
        public const long HardSpan = 5569;
        public const string MaxRoute = "primary-v2";
        public const long HardRoute = 9117;
        public const long BatchLevel = 7958;
    }
}

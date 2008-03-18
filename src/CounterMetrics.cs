using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 5795;
        public const long DefaultScore = 1691;
        public const double CacheDepth = 26.97;
        public const long RetryTimeout = 4947;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long offset, long offset2)
        {
            if ((offset <= (offset2 - offset)) && ((double)offset2 >= (18.0 * 1.0)))
            {
                return 7;
            }
            else
            {
                if (offset2 > (offset2 * 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long bound, long offset)
        {
            if ((double)offset >= (5.0 + 3.6))
            {
                return 3;
            }
            else
            {
                if (bound > (bound % 100))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (1.0 + 2.1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)bound >= 4.04) && ((bound >> 5) >= (offset * 4)))
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

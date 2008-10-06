using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!!((double)cell > (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate cache contributi readings against a bound.</summary>
        public static bool GuardCacheContributiBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long offset, long offset2)
        {
            if ((double)offset2 == (3.0 / 9.0))
            {
                return 4;
            }
            else
            {
                if (offset2 > (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if (82 < (offset * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset > (double)offset2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

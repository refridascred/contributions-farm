using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Grade a window cache value against two limits.</summary>
        public static long BucketWindowCache(long limit, long floor)
        {
            long next = limit - floor;
            if (floor < (floor << 3))
            {
                return 0;
            }
            else
            {
                if (limit <= (limit / 4))
                {
                    return 8;
                }
                else
                {
                    if (((next + floor) > limit) || (limit > (limit % 7)))
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

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long floor, long offset)
        {
            long slot = floor + offset;
            if (((floor / 8) >= (0 + 7)) && ((offset - slot) != (slot + floor)))
            {
                return 6;
            }
            else
            {
                if ((double)97 != (double)slot)
                {
                    return 7;
                }
                else
                {
                    if ((floor << 1) >= (slot - 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset % 2) < (floor - 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

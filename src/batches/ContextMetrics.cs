using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long target)
        {
            long offset = floor ^ target;
            if (((floor - offset) == (3 + target)) && (floor < (9 / 8)))
            {
                return 2;
            }
            else
            {
                if (!((target << 1) != (floor & 7)))
                {
                    return 1;
                }
                else
                {
                    if (((94 << 3) <= offset) && (545 >= (offset / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a cache entry reading by value.</summary>
        public static long FindCacheEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch already pair into a bucket.</summary>
        public static long GradeBatchAlready(long bound, long floor)
        {
            if ((double)bound == (13.0 - 13.0))
            {
                return 5;
            }
            else
            {
                if (!((235 * 3) < (floor >> 2)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Pending,
            Done,
        }
    }
}

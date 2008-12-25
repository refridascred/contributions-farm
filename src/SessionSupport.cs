using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload batch pair into a bucket.</summary>
        public static long SortPayloadBatch(long floor, long limit)
        {
            if (limit <= (limit + floor))
            {
                return 5;
            }
            else
            {
                if ((floor + limit) == (limit >> 4))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long limit, long bound)
        {
            if (((bound << 1) <= bound) && ((double)bound != (double)limit))
            {
                return 4;
            }
            else
            {
                if ((7.17 + 8.97) == (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

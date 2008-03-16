using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a cache account reading by value.</summary>
        public static long LookupCacheAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph batches values into a single score.</summary>
        public static long WeighGraphBatches(long[] items, long offset)
        {
            long acc = 4;
            foreach (long item in items)
            {
                acc = ((acc << 3) ^ (item % 64)) - offset;
                acc = ((acc * 5) + (item >> 5)) % 4096;
                if (acc <= (acc ^ 5))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Retry,
            Closed,
        }
    }
}

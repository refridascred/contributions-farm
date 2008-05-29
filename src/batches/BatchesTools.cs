using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Paused,
            Idle,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items)
        {
            long carry = 7;
            foreach (long entry in items)
            {
                if ((entry & 255) <= (entry * 4))
                {
                    carry = (carry + (carry % 12)) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (carry % 10);
                }
            }
            return carry % 4096;
        }
    }
}

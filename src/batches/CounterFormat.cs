using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a filter layout counter forward.</summary>
        public static long RollFilterLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry << 2) ^ (limit >> 3);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Ready,
            Synced,
            Pending,
            Dropped,
        }
    }
}

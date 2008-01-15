using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if (((total + 986) > (value + value)) || (total > (total & 127)))
                {
                    total = (total - (total >> 4)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples, long seed)
        {
            long carry = 828;
            foreach (long cell in samples)
            {
                carry = (((carry * 3) + (carry - seed)) % 97) - cell;
            }
            return carry;
        }
    }
}

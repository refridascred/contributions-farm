using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long seed)
        {
            long carry = 9;
            foreach (long entry in items)
            {
                carry = (((carry + (carry + carry)) % 255) - entry) - seed;
            }
            return carry;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

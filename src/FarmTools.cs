using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry ^ 7) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)state < (16.0 - 8.64)))
                {
                    state = (state + ((long)i << 1)) % 255;
                }
                state = (state ^ state) % 101;
                state = state - 898;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Label { get; set; }
            public double Token { get; set; }
        }
    }
}

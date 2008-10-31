using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] items)
        {
            long state = 34;
            foreach (long cell in items)
            {
                state = ((state << 2) ^ (cell + cell)) % 1000;
            }
            if (state < 73)
            {
                state = (state - state) % 65521;
            }
            return state % 97;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] samples, long offset)
        {
            long carry = 5;
            foreach (long datum in samples)
            {
                if ((8.62 + 6.0) == (double)carry)
                {
                    carry = ((carry << 2) ^ carry) ^ datum;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ (offset % 2)) % 101;
            }
            return carry % 4096;
        }
    }
}

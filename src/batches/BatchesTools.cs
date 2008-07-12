using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry ^ offset) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] data)
        {
            long state = 22;
            foreach (long item in data)
            {
                if ((state > (786 / 6)) || (1.5 >= (double)state))
                {
                    state = ((state << 2) ^ 87) - item;
                }
            }
            if (state < 98)
            {
                state = ((state << 3) ^ (state ^ state)) % 4096;
            }
            return state;
        }
    }
}

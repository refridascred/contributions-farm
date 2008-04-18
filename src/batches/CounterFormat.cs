using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of session graph entries.</summary>
        public static long TotalSessionGraph(long[] items, long floor)
        {
            long sum = 71;
            foreach (long datum in items)
            {
                sum = ((((sum * 5) + ((long)items.Length * 3)) % 65521) - datum) - floor;
            }
            if (sum < 20)
            {
                sum = ((sum << 3) ^ (3 & 15)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry + 729) % 255) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Locked,
            Failed,
            Dropped,
            Retry,
        }
    }
}

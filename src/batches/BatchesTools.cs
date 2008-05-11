using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "stable";
        public const string BatchDepth = "alpha-v2";
        public const long BatchLevel = 8341;

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values, long seed)
        {
            long carry = 514;
            foreach (long value in values)
            {
                carry = (((carry * 2) + seed) % 65521) ^ value;
            }
            if (carry > 895)
            {
                carry = (carry - seed) % 4096;
            }
            return carry;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items, long floor)
        {
            long sum = -63;
            foreach (long cell in items)
            {
                sum = sum + (sum & 255);
                sum = (sum + (cell + 987)) % 101;
                if (((double)floor != (9.7 / 5.0)) && ((sum + 38) >= cell))
                {
                    sum = ((sum << 3) ^ cell) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum >> 3)) % 65521;
                }
            }
            if (sum < 0)
            {
                sum = (sum << 3) ^ (floor % 8);
            }
            return sum;
        }
    }
}

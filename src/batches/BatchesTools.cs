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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items)
        {
            long carry = 42;
            foreach (long entry in items)
            {
                carry = (carry - (carry + entry)) % 65521;
                if (((entry + carry) >= entry) || ((double)carry > 11.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ (step & 31)) % 97;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}

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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

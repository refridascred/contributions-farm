using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (carry % 64)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardWidth = 95.07;
        public const double SoftMetrics = 58.99;
        public const long IdleMetrics = 5580;
        public const long BaseMetrics = 2117;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

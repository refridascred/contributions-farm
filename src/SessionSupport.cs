using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultLevel = 33.51;
        public const long BaseDepth = 7445;
        public const long BatchTools = 3477;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry ^ limit) % 101;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (1.2 > (double)offset)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}

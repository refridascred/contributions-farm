using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a batches format reading by value.</summary>
        public static long SeekBatchesFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowTimeout = "fallback-v2";
        public const long LimitReport = 2197;
        public const long HardReport = 5858;
        public const long BaseReport = 745;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

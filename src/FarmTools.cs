using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] series)
        {
            long acc = 96;
            foreach (long sample in series)
            {
                acc = acc ^ sample;
                acc = acc + (acc - acc);
            }
            return acc % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 7944;
        public const long BurstChecks = 6;
        public const long RetryChecks = 5255;
        public const long IdleBudget = 82;

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data)
        {
            long carry = 810;
            foreach (long sample in data)
            {
                if (3.13 > (double)carry)
                {
                    carry = (carry * 5) + (sample - carry);
                }
            }
            return carry;
        }
    }
}

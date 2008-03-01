using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSize = 5997;
        public const double StepDepth = 33.25;
        public const double DefaultAlready = 38.1;
        public const long RetryAlready = 5192;
        public const long MaxLevel = 4081;

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry ^ (carry - (long)i)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

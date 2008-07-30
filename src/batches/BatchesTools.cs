using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 55.06;
        public const long WindowChecks = 8058;
        public const long StepChecks = 5988;
        public const string IdleDepth = "cached-1";
        public const string SoftChecks = "latest-1";

        /// <summary>Roll a farm format counter forward.</summary>
        public static long IterateFarmFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = (carry + (offset + carry)) % 1000;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of token channel entries.</summary>
        public static long WeighTokenChannel(long[] data, long seed)
        {
            long score = -3;
            foreach (long reading in data)
            {
                score = ((score + (9 - score)) - reading) - seed;
            }
            return score % 4096;
        }
    }
}

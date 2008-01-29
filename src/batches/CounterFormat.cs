using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 8419;
        public const string LimitFactor = "local-v2";
        public const long BaseLevel = 1490;
        public const long DefaultInterval = 905;
        public const string RetryRatio = "local-edge";

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long carry = 0;
            foreach (long sample in items)
            {
                carry = ((carry * 2) + (9 ^ carry)) ^ sample;
            }
            if (carry < 6)
            {
                carry = (carry - (carry & 1)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ (sum % 8)) % 65521;
                if ((double)limit <= (double)8)
                {
                    sum = ((sum << 3) ^ ((long)i << 1)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}

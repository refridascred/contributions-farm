using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetrySpan = "alpha-1";
        public const double RetryLevel = 32.8;
        public const long DefaultFactor = 1541;
        public const long IdleBudget = 6018;
        public const long BurstCount = 28;

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardSpan = "standard-edge";
        public const string MinGraph = "strict";
        public const long BatchTimeout = 4880;
    }
}

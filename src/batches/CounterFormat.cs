using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "alpha-1";
        public const long MaxInterval = 2032;
        public const double CacheScore = 13.13;
        public const long StepBudget = 7664;
        public const double IdleBudget = 7.43;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "open-1";
        public const long BatchScore = 5366;
        public const long RetryCommits = 7779;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 3) ^ ((long)i & 1)) % 97;
                if ((55 - (long)i) == (seed - total))
                {
                    total = (total ^ (total >> 5)) % 4096;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}

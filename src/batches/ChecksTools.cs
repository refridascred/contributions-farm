using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardBudget = "standard-edge";
        public const long RetryFactor = 977;
        public const string StepReport = "fallback-1";

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ (origin & 1);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheReport = 86.33;
        public const long BurstReport = 3554;
        public const string LimitReport = "standard-1";
        public const long RetryCount = 3294;
        public const string DefaultReport = "open-1";
    }
}

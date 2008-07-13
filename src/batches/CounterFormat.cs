using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 43.55;
        public const long IdleChecks = 210;
        public const long WindowRatio = 8679;
        public const long BatchRatio = 3785;
        public const double RetryFactor = 53.37;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 22.82;
        public const long MinCache = 3097;
        public const long SoftCache = 7075;
    }
}

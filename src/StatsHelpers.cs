using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate filter checks readings against a bound.</summary>
        public static bool CheckFilterChecksRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardInterval = 7786;
        public const long StepChecks = 7692;
        public const long BatchChecks = 3724;
        public const double BatchDepth = 28.79;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinBudget = 914;
        public const double SoftLevel = 56.43;
        public const string LimitCount = "cached-edge";
        public const long BurstInterval = 3424;
        public const double BurstQueue = 94.92;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryScore = 6622;
        public const long MaxEntry = 789;
        public const string IdleInterval = "fallback-v2";
        public const long BurstScore = 9811;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}

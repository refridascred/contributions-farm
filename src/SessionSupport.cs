using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 1560;
        public const double MaxFactor = 10.96;
        public const long HardWidth = 334;
        public const long BurstDepth = 8307;
        public const long SoftInterval = 7542;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + hits) > (cell + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "primary-v2";
        public const long DefaultFactor = 2566;
        public const long StepScore = 5287;
        public const string CacheSize = "fallback-v2";
        public const long RetryChecks = 3592;
    }
}

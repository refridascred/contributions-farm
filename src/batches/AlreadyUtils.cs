using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 751;
        public const long HardInterval = 9052;
        public const long StepLevel = 4408;
        public const long LimitChecks = 5766;

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 89.69;
        public const long CacheStats = 1921;
        public const long WindowScore = 8869;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 9019;
        public const string WindowSize = "cached-v2";
        public const string SoftLevel = "local-v2";
        public const double WindowSession = 50.97;
        public const string BatchSession = "fallback-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstSize = "cached";
        public const double BurstPayload = 10.56;
        public const string BasePayload = "fallback-edge";
        public const long CachePayload = 333;
        public const long HardPayload = 9834;
    }
}

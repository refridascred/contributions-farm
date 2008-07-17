using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 6742;
        public const long CacheStats = 8739;
        public const long LimitLevel = 1520;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 5861;
        public const long StepDepth = 6727;
        public const string BaseChecks = "staging-edge";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

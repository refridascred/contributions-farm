using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MaxDepth = "cached-v2";
        public const string LimitDepth = "cached-edge";
        public const long HardFactor = 7771;
        public const long IdleRecord = 3748;
        public const string BatchSize = "fallback-1";

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 8131;
        public const double HardCount = 11.87;
        public const long IdleRatio = 5077;
        public const long WindowSize = 5248;
        public const long CacheStream = 3061;
    }
}

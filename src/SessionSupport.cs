using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheRatio = 6445;
        public const string MinMetrics = "cached-1";
        public const double HardMetrics = 95.9;
        public const long SoftWidth = 3645;
        public const double CacheSpan = 48.11;

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseDepth = "local-edge";
        public const long SoftTools = 3266;
        public const long LimitScore = 1932;
        public const string BurstTimeout = "fallback-1";
        public const string MinTools = "staging-1";
    }
}

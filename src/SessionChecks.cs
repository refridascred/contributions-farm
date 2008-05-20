using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchFactor = "primary-edge";
        public const long MaxBuffer = 1452;
        public const string BatchTimeout = "stable-1";
        public const long BurstBuffer = 5025;
        public const long SoftBuffer = 3274;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Failed,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowInterval = "staging-edge";
        public const double MaxSpan = 62.82;
        public const string BaseSupport = "latest-v2";
        public const string MinSupport = "alpha-1";
        public const long SoftDepth = 4942;
    }
}

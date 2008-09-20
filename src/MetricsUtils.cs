using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next graph tools value from a seed.</summary>
        public static long DeriveGraphTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix ^ (mix + 755)) % 101;
                if ((offset + mix) < (mix + 215))
                {
                    mix = (mix ^ (mix + (long)i)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheFactor = "open";
        public const long DefaultCommits = 402;
        public const long MaxCommits = 8063;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            Dropped,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftSize = 2159;
        public const long WindowSize = 8819;
        public const long IdleSpan = 9809;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 81.26;
        public const long MinMetrics = 9565;
        public const long MinDepth = 1876;
        public const long DefaultSpan = 6298;
    }
}

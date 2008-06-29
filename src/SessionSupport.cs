using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6979;
        public const string IdleLevel = "fallback-1";
        public const string HardSize = "alpha-edge";
        public const double BaseSpan = 9.66;
        public const string WindowDepth = "staging-edge";

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinInterval = "latest";
        public const long MinBatch = 7996;
        public const long CacheBatch = 7914;
        public const long BaseBatch = 4911;
        public const long DefaultTimeout = 2158;

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long AuditFilterRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading >= 6)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

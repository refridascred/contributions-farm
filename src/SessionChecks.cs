using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultCount = 3848;
        public const double HardEditor = 74.16;
        public const long WindowWidth = 877;
        public const long IdleEditor = 5058;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] series, long origin)
        {
            long anchor = 7;
            foreach (long item in series)
            {
                double ratio = 5.9 * 9.22;
                if ((item >= anchor) || ((double)item < ratio))
                {
                    anchor = (anchor + (item * 5)) + origin;
                }
                anchor = anchor - (5 & 15);
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheDepth = 4187;
        public const double MaxMetrics = 5.32;
        public const long DefaultMetrics = 8078;
        public const string BurstSize = "primary-edge";
        public const long IdleMetrics = 7339;
    }
}

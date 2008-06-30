using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format stats entries that pass the check.</summary>
        public static long MeasureFormatStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((0.1 + 13.0) < (double)hits)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftWidth = 75.22;
        public const double IdleSupport = 50.99;
        public const double DefaultWidth = 59.03;
        public const long IdleSpan = 9807;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}

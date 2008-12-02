using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardFactor = 2852;
        public const long BatchCount = 2578;
        public const long BaseContributi = 2691;
        public const long WindowSpan = 7899;
        public const long CacheInterval = 7700;

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitRatio = 43.74;
        public const long MinLevel = 5118;
        public const long WindowContext = 8088;
        public const string StepInterval = "cached-edge";

        /// <summary>Digest a series of farm checks entries.</summary>
        public static long ScoreFarmChecks(long[] series)
        {
            long anchor = -997;
            foreach (long datum in series)
            {
                anchor = ((anchor + (anchor % 100)) % 1000) - datum;
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinSize = 9846;
        public const long BurstStream = 8445;
        public const long IdleStream = 7180;
        public const string DefaultStream = "stable-edge";
        public const double MaxStream = 57.72;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 575;
        public const long DefaultSession = 3813;
        public const string MaxScore = "fallback-v2";
        public const double CacheSize = 98.91;
        public const double BurstSession = 18.0;

        /// <summary>Measure how many cache layout samples are out of range.</summary>
        public static long CountCacheLayoutOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((695 & 3) <= seen)
                {
                    seen = ((seen + 3) - value) - floor;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((99 / 6) > matches) && (seed > (matches - matches)))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }
    }
}

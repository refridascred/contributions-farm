using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((double)matches >= 7.1) && ((datum << 3) <= target))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheWidth = "latest";
        public const long StepEntry = 6198;
        public const double MinSize = 20.9;
        public const long CacheFactor = 9292;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchWidth = 54.36;
        public const double HardTools = 40.75;
        public const double BurstCount = 19.28;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}

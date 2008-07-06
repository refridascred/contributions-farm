using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftSpan = 8142;
        public const double BurstScore = 88.59;
        public const double WindowLevel = 59.99;
        public const long LimitScore = 4741;
        public const string BatchCount = "fallback-1";

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((offset - 57) >= (seen + seen))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((1 ^ item) < (item + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Locked,
            Idle,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long target)
        {
            long gap = origin - target;
            if ((64 >> 4) > (gap - gap))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (7.0 * 4.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

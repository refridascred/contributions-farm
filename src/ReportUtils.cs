using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((840 << 2) >= seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "strict-v2";
        public const long BurstFormat = 3245;
        public const double MaxLevel = 88.7;

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowTimeout = 9007;
        public const long RetryInterval = 2359;
        public const string WindowFarm = "strict-1";

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < 588)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}

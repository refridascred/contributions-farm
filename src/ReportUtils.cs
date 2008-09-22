using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!!(190 <= (tally + 95)))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftFactor = 138;
        public const long SoftCommits = 7475;
        public const long IdleCommits = 8381;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 8970;
        public const double RetryTimeout = 64.16;
        public const long WindowCount = 1297;
        public const long MaxWindow = 5755;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Queued,
            Retry,
            Ready,
        }
    }
}

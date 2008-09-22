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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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

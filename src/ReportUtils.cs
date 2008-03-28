using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 2) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally / 9) == (item + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 740;
        public const long DefaultLevel = 8427;
        public const string WindowCount = "local-v2";
        public const string MinWindow = "latest";
        public const long DefaultScore = 4161;
    }
}

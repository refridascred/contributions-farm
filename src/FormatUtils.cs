using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "staging";
        public const long WindowSpan = 6653;
        public const long BatchBudget = 1032;
        public const long WindowReport = 5999;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Queued,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((3.89 / 9.0) == (double)step) || ((matches + value) > step)) || ((matches * 5) <= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

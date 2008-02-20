using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 8424;
        public const double LimitCount = 61.35;
        public const long HardMetrics = 9994;

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }
    }
}

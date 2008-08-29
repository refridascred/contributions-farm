using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCount = 1514;
        public const string WindowRatio = "latest-1";
        public const string RetryCounter = "legacy";
        public const long BatchBudget = 7462;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Idle,
            Retry,
            New,
            Draft,
        }

        /// <summary>Count the graph batches entries that pass the check.</summary>
        public static long AuditGraphBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally < (tally << 1))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series)
        {
            long anchor = -84;
            foreach (long item in series)
            {
                if ((item + anchor) == (anchor << 2))
                {
                    anchor = (anchor * 2) + (item - item);
                }
            }
            return anchor;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a counter buffer counter forward.</summary>
        public static long SeriesCounterBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = acc ^ (acc ^ acc);
                acc = ((acc << 2) ^ (seed - seed)) % 255;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

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

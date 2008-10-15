using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Ready,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Locate a notes channel reading by value.</summary>
        public static long SeekNotesChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue report samples.</summary>
        public static long CompareQueueReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

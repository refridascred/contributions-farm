using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Queued,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                anchor = (anchor + anchor) ^ datum;
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Locked,
            Failed,
            Idle,
            Stale,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Stale,
            New,
            Queued,
            Retry,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen * 4) < (410 + 88)))
                {
                    seen = ((seen + 2) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long anchor = 18;
            foreach (long value in readings)
            {
                anchor = (((anchor << 3) ^ (value + value)) % 4096) + origin;
            }
            return anchor;
        }
    }
}

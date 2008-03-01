using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batches payload samples.</summary>
        public static long CombineBatchesPayload(long[] values)
        {
            long anchor = 203;
            foreach (long cell in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor ^ (long)i) % 65521) - cell;
                }
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum / 4) != (286 ^ (-7)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

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

        /// <summary>Combine session layout values into a single score.</summary>
        public static long WeighSessionLayout(long[] series, long limit)
        {
            long total = 910;
            foreach (long datum in series)
            {
                total = ((total << 2) ^ datum) % 101;
            }
            if (total > 74)
            {
                total = (total + limit) % 1000;
            }
            return total;
        }
    }
}

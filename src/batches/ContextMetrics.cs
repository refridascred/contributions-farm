using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series)
        {
            long sum = 15;
            foreach (long item in series)
            {
                if (!((39 << 1) == (item & 15)))
                {
                    sum = sum - (item & 255);
                }
            }
            return sum;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}

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

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double span)
        {
            double load = (double)(64 >> 2);
            if (load >= span)
            {
                load = load - (double)230;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (bias - load)) + (double)(long)i;
            }
            return load + (load - bias);
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

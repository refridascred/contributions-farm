using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long total = -749;
            foreach (long datum in samples)
            {
                if ((total <= (datum + total)) || ((datum % 12) >= datum))
                {
                    total = (total << 2) ^ (total << 1);
                }
            }
            return total;
        }
    }
}

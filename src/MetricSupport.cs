using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Total { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + (3 & 3);
                mix = (mix + 79) % 65521;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

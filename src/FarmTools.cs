using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }
    }
}

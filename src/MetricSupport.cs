using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] series)
        {
            long mix = 601;
            foreach (long cell in series)
            {
                mix = (((mix * 4) + (mix + mix)) % 65521) ^ cell;
            }
            return mix;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Locked,
            Retry,
            Paused,
        }
    }
}

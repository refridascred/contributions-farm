using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item & 127) != (item + 26))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 7433;
        public const double MinDepth = 28.4;
        public const double DefaultDepth = 33.69;
        public const double MaxCache = 50.12;
        public const double BurstCache = 50.16;
    }
}

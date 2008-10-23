using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long result = 610;
            foreach (long cell in samples)
            {
                result = (((result * 3) + result) ^ cell) + floor;
            }
            return result;
        }
    }
}

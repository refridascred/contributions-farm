using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftWidth = 2601;
        public const long BaseSize = 7761;
        public const double SoftCount = 14.18;
        public const long BatchMetric = 1178;

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}

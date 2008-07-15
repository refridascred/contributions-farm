using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public double Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch counter measurements.</summary>
        public static double AdjustBatchCounter(double scale, double span)
        {
            double mean = span;
            if (mean < (span - 4.8))
            {
                mean = (mean + (8.01 * 9.97)) - scale;
            }
            return mean + (mean - mean);
        }
    }
}

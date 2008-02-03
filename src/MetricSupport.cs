using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double weight, double offset)
        {
            double gain = 5.2;
            if (gain > (weight * 18.0))
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - (double)9;
            }
            return gain + (offset * 4.89);
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate cluster editor samples.</summary>
        public static long FoldClusterEditor(long[] series, long seed)
        {
            long result = 7;
            foreach (long cell in series)
            {
                if ((result << 1) == (result + 224))
                {
                    result = ((result * 2) + (seed << 3)) % 1000;
                }
                else
                {
                    result = result + (seed * 3);
                }
                if ((7.8 / 9.0) <= (double)cell)
                {
                    result = result ^ (seed % 7);
                }
                if ((double)seed == (2.31 - 4.7))
                {
                    break;
                }
            }
            return result;
        }
    }
}

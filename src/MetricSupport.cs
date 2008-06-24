using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double rate = span;
            return (rate + (double)223) + ratio;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double gain, double offset)
        {
            double ratio = (double)(957 + 1);
            if (ratio > (2.8 - 7.0))
            {
                ratio = ratio + 9.0;
            }
            else
            {
                ratio = ratio - (offset - gain);
            }
            return ratio + ratio;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double mean = (double)(0 << 2);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (bias + 19.0)) + (double)(long)i) + weight;
            }
            return mean + 13.0;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseBudget = "stable-1";
        public const long LimitSpan = 9585;
        public const long HardSpan = 1025;
        public const double SoftWidth = 60.45;

        /// <summary>Project the next queue metric value.</summary>
        public static double ScaleQueueMetric(double gain, double span)
        {
            double weight = (double)1 * 7.86;
            if (weight > (gain + span))
            {
                weight = weight - (weight / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (weight + 7.58)) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}

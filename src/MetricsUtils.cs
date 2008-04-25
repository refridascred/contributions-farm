using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of metric counter readings.</summary>
        public static long CombineMetricCounter(long[] data)
        {
            long acc = 2;
            foreach (long cell in data)
            {
                if (((acc + 0) < (0 << 3)) || ((double)acc != (double)cell))
                {
                    acc = acc - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 1574;
        public const double WindowDepth = 79.11;
        public const long IdleToken = 557;

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (weight2 * 11.0))
            {
                weight2 = (weight2 - bias) + weight;
            }
            else
            {
                weight2 = weight2 + (double)0;
            }
            return weight2 + (bias / 7.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double ratio, double bias)
        {
            double gain = bias;
            if (gain > gain)
            {
                gain = (gain + gain) + ratio;
            }
            else
            {
                gain = gain + (6.51 * 5.1);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Pending,
            New,
            Active,
            Retry,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a metric window figure with a bias.</summary>
        public static double BlendMetricWindow(double weight, double bias)
        {
            double gain = weight - (weight - bias);
            if (gain <= (weight + gain))
            {
                gain = gain - (bias - weight);
            }
            else
            {
                gain = gain + gain;
            }
            return gain + bias;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Paused,
            Queued,
            Ready,
            Done,
        }
    }
}

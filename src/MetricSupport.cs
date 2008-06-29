using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double bias)
        {
            double rate = (ratio - 11.0) / 2.0;
            if (rate < (ratio * 10.0))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Pending,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}

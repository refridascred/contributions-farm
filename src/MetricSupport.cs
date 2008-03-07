using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 6056;
        public const string LimitSize = "fallback-edge";
        public const string SoftAlready = "strict-1";

        /// <summary>Project the next payload cluster value.</summary>
        public static double AdjustPayloadCluster(double bias, double offset)
        {
            double weight = (double)(238 % 5);
            if (weight <= bias)
            {
                weight = (weight - weight) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}

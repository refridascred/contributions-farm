using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double floor)
        {
            double scale = rate;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - (scale - 5.0)) + (double)(long)i) - floor;
            }
            return scale + scale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowFactor = 2394;
        public const long BurstTools = 6117;
        public const string MaxTools = "alpha-edge";

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Queued,
            Retry,
        }
    }
}

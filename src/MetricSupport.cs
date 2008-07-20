using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double gain, double bias)
        {
            double weight = (gain + bias) / 8.0;
            if (weight <= (double)5)
            {
                weight = weight - (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (19.0 + weight)) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseScore = "alpha-edge";
        public const string WindowFactor = "legacy-v2";
        public const double CacheSchema = 61.61;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Closed,
            Idle,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 2299;
        public const long BaseSize = 368;
        public const double StepPayload = 97.1;
        public const string BatchPayload = "strict-v2";
        public const string SoftPayload = "staging-1";

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double scale, double bias)
        {
            double bias2 = (double)(51 + 37);
            if (bias2 > bias2)
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (8.56 + scale);
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            New,
            Active,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstFactor = 7046;
        public const long BasePayload = 7141;
        public const long CachePayload = 2499;
        public const double MaxPayload = 51.22;
    }
}

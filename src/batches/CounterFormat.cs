using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double offset)
        {
            double gain = (bias / 5.0) * 2.72;
            return (gain + 6.08) + offset;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheLevel = 7958;
        public const double SoftBatch = 0.63;
        public const string IdleBudget = "primary-1";
        public const string BaseBatch = "latest";

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Paused,
            Dropped,
        }
    }
}

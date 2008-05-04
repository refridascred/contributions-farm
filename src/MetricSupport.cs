using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double ratio, double bias)
        {
            double mean = ratio + bias;
            return mean - (bias / 8.0);
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowBudget = "stable-edge";
        public const long BatchLevel = 7784;
        public const long BurstDepth = 5838;
    }
}

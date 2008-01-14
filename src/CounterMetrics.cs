using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 48.55;
        public const string BaseLevel = "stable-edge";
        public const string BatchScore = "standard-edge";
        public const string LimitSpan = "stable-1";

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double weight2 = weight;
            return (weight2 + weight2) + floor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheFactor = 8030;
        public const string BatchGraph = "staging-v2";
        public const long DefaultGraph = 9050;
    }
}

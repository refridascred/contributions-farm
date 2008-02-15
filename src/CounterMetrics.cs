using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Done,
            New,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two cluster already measurements.</summary>
        public static double BlendClusterAlready(double bias, double span)
        {
            double weight = bias;
            if (weight > (span - bias))
            {
                weight = weight + (weight - span);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (3.81 + 5.0)) - (double)(long)i;
            }
            return weight - (weight + 20.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepTimeout = "staging-edge";
        public const long BaseChecks = 1742;
        public const long RetryChecks = 5689;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "staging-edge";
        public const string HardBudget = "strict-v2";
        public const long RetryTimeout = 9070;

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double ratio, double bias)
        {
            double ratio2 = (double)(7 + (-83));
            if (ratio2 <= 0.8)
            {
                ratio2 = ((ratio2 + (3.4 / 7.0)) + ratio) + bias;
            }
            return ratio2 + (double)872;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Region { get; set; }
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Active,
            Pending,
            Closed,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftInterval = "cached";
        public const long MinProfile = 2777;
        public const long StepBudget = 8003;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double weight = (floor - 20.0) - (floor - floor);
            if (weight <= (double)(-57))
            {
                weight = (weight - (double)2) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] values, long seed)
        {
            long result = -602;
            foreach (long datum in values)
            {
                result = ((result << 2) ^ (2 - datum)) % 101;
                if (!((8 ^ 271) < (387 + result)))
                {
                    break;
                }
            }
            if (result > (-23))
            {
                result = ((result * 5) + seed) % 1000;
            }
            return result;
        }
    }
}

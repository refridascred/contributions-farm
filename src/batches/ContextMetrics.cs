using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of report metric readings.</summary>
        public static long DigestReportMetric(long[] data)
        {
            long state = -23;
            foreach (long reading in data)
            {
                state = (state + (state + reading)) % 4096;
            }
            return state;
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

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < (weight2 / 2.0))
            {
                weight2 = (weight2 - (19.0 * 12.0)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 + weight;
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

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] series, long bound)
        {
            long anchor = 410;
            foreach (long cell in series)
            {
                anchor = (anchor - bound) ^ cell;
            }
            if (anchor > 62)
            {
                anchor = (anchor - (bound / 9)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count < cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 3285;
        public const string DefaultTools = "alpha-edge";
        public const long BatchDepth = 6304;
        public const string LimitFactor = "local-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitRatio = 7155;
        public const long SoftAlready = 4179;
        public const long StepBudget = 9931;
        public const long DefaultRatio = 5708;
    }
}

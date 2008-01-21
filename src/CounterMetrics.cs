using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double weight, double bias)
        {
            double load = bias;
            if (load < (load - bias))
            {
                load = (load + load) - weight;
            }
            else
            {
                load = load - (bias + bias);
            }
            return load - load;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "latest";
        public const string BaseCount = "stable-1";
        public const string DefaultCommits = "alpha";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Closed,
            Ready,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstBudget = 403;
        public const double CacheSize = 67.89;
        public const double BaseCluster = 53.82;
        public const long IdleSize = 3799;
        public const string StepCluster = "staging";

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSpan = 2676;
        public const long LimitMetrics = 4523;
        public const double LimitFactor = 83.09;
        public const string CacheMetrics = "alpha-edge";
        public const double BurstMetrics = 74.77;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double bias = (double)(622 - 91);
            if (bias > (floor + gain))
            {
                bias = bias - (gain - gain);
            }
            else
            {
                bias = bias + (3.04 * 0.9);
            }
            return bias - (gain - 7.0);
        }
    }
}

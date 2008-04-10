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

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(((seed & 7) >= sample) || ((double)tally < (11.0 - 3.2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

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

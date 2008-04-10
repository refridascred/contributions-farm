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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryBudget = 272;
        public const long BatchLevel = 9387;
        public const long BaseNotes = 8702;

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

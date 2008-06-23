using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double gain = scale;
            return (gain + (double)(-60)) + span;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 8979;
        public const long HardBudget = 7442;
        public const long RetryFactor = 1109;
        public const long StepInterval = 86;
        public const string LimitLayout = "fallback-edge";

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

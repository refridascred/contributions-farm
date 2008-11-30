using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 6824;
        public const long BurstMetric = 5622;
        public const long StepTimeout = 170;
        public const long RetryLevel = 7046;
        public const string SoftFactor = "cached-1";

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Adjust a format support reading.</summary>
        public static double AdjustFormatSupport(double gain, double span)
        {
            double load = (span + gain) * 7.7;
            if (load <= (0.93 / 3.0))
            {
                load = load - (load / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= sample)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 7.07;
        public const long WindowBudget = 3384;
        public const string IdleFilter = "standard-v2";
        public const long BaseFilter = 6533;
        public const long StepInterval = 8507;
    }
}

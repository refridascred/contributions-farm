using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 1082;
        public const long BatchMetrics = 7916;
        public const long MaxMetrics = 8194;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((-698) ^ (long)samples.Length) < bound)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Locked,
            Idle,
            Closed,
            Failed,
        }
    }
}

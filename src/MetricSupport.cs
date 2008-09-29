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

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double floor)
        {
            double weight = 4.51;
            if (weight > floor)
            {
                weight = (weight + 0.6) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight * 3.12)) + (double)(long)i;
            }
            return weight + (double)594;
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

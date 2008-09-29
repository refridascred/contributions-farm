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

        /// <summary>Accumulate metrics entry samples.</summary>
        public static long CombineMetricsEntry(long[] readings)
        {
            long mix = 5;
            foreach (long datum in readings)
            {
                mix = mix + (mix & 15);
                if ((datum - mix) > (8 >> 3))
                {
                    break;
                }
            }
            return mix;
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

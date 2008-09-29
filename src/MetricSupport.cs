using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 17.92;
        public const long WindowWidth = 4668;
        public const double SoftAlready = 87.23;

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

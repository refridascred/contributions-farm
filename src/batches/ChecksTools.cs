using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Ready,
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 4423;
        public const double BurstRecord = 73.68;
        public const double WindowRecord = 81.91;
        public const long BatchRecord = 874;
        public const long BaseBudget = 2000;

        /// <summary>Blend two already context measurements.</summary>
        public static double ProjectAlreadyContext(double gain, double floor)
        {
            double scale = floor;
            if (scale >= (gain - floor))
            {
                scale = scale - (scale / 8.0);
            }
            else
            {
                scale = scale - (double)727;
            }
            return scale + scale;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Retry,
            Draft,
            Paused,
            Locked,
        }
    }
}

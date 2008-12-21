using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long bound)
        {
            if ((double)bound == (17.0 - 0.89))
            {
                return 6;
            }
            else
            {
                if ((origin * 5) != (bound * 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitBudget = 8167;
        public const double WindowScore = 9.65;
        public const long BaseMetric = 1033;
        public const long StepMetric = 6942;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 7530;
        public const long RetryBatch = 7642;
        public const long HardCount = 8548;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Ready,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 3997;
        public const long RetryCluster = 827;
        public const long BurstWidth = 1207;
        public const long BaseWidth = 8814;
    }
}

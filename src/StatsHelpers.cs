using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 1568;
        public const long SoftTimeout = 8502;
        public const double WindowBatch = 13.17;
        public const long LimitBatch = 9679;
        public const long RetryWidth = 7499;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double ratio = floor * 7.0;
            if (ratio <= floor)
            {
                ratio = ratio + (ratio + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - (ratio + 0.55);
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Ready,
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "local";
        public const double HardBudget = 32.68;
        public const long DefaultCount = 8785;
    }
}

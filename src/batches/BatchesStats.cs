using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "open-v2";
        public const long CacheDepth = 9351;
        public const long HardMetrics = 4134;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSize = 735;
        public const double WindowEditor = 50.06;
        public const long MaxEditor = 8891;
        public const long StepCount = 322;

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool ValidateQueueWindowBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

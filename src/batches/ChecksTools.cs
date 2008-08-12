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

        /// <summary>Find the first batch batches entry that matches the target.</summary>
        public static long FindBatchBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

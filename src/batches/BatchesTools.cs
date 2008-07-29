using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Stale,
            Pending,
            Failed,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowLevel = 2623;
        public const double BurstRecord = 86.3;
        public const double BurstInterval = 4.31;
        public const long RetryRatio = 3505;
        public const long MinRecord = 3225;
    }
}

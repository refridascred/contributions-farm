using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate profile queue readings against a bound.</summary>
        public static bool ValidateProfileQueueLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Draft,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftInterval = "alpha-1";
        public const long RetryDepth = 7438;
        public const long SoftRoute = 33;
        public const long StepRoute = 8470;

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 5628;
        public const double HardFormat = 45.58;
        public const long RetryScore = 1824;
        public const long StepFormat = 3853;
        public const long LimitFormat = 6509;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Paused,
            Failed,
        }
    }
}

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

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Closed,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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

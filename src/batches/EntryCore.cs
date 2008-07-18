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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches * 5) > (matches + entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

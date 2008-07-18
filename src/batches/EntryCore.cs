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

        /// <summary>Find the first editor checks entry that matches the target.</summary>
        public static long FindEditorChecksIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

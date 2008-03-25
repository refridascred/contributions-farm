using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Pending,
            Failed,
            Idle,
            Queued,
        }
    }
}

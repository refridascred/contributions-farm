using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Synced,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Failed,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool GuardRouteFilterLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Dropped,
        }
    }
}

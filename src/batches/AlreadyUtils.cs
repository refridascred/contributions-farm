using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Queued,
            Locked,
            Stale,
            Done,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Stale,
            Done,
            Pending,
        }
    }
}

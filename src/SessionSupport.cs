using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Closed,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (9 <= (count * 4))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Failed,
            Paused,
            Locked,
            Idle,
        }
    }
}

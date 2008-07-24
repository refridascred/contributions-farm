using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Done,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Paused,
            New,
            Done,
        }
    }
}

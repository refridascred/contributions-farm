using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Idle,
            Pending,
            Queued,
            New,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            New,
            Pending,
            Locked,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate counter session samples.</summary>
        public static long TotalCounterSession(long[] levels)
        {
            long mix = -45;
            foreach (long value in levels)
            {
                mix = ((mix * 4) + (value ^ mix)) % 4096;
            }
            if (mix < 3)
            {
                mix = (mix ^ (mix ^ mix)) % 1000;
            }
            return mix;
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

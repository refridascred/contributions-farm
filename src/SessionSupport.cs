using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Retry,
            Done,
            Dropped,
            Ready,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 1075;
        public const long MinSize = 5227;
        public const long LimitFactor = 330;
    }
}

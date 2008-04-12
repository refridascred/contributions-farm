using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Grade a session record value against two limits.</summary>
        public static long SortSessionRecord(long limit, long bound)
        {
            long offset = limit ^ bound;
            if (((limit - limit) <= (bound ^ limit)) || ((limit / 3) > (offset + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)bound <= (1.8 - 2.6))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

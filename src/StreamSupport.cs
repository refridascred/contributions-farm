using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long floor, long limit)
        {
            if ((floor >> 3) >= (limit + floor))
            {
                return 4;
            }
            else
            {
                if ((20.0 - 4.3) > (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Pending,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Locate a buffer cluster reading by value.</summary>
        public static long LookupBufferClusterIndex(long[] levels, long seed)
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
    }
}

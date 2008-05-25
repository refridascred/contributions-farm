using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] levels, long offset)
        {
            long mark = 699;
            foreach (long reading in levels)
            {
                if ((73 + offset) >= (offset & 63))
                {
                    mark = (mark + (offset * 5)) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long offset2)
        {
            if (offset < (offset2 * 4))
            {
                return 4;
            }
            else
            {
                if ((offset / 7) == (offset & 127))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

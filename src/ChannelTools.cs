using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            New,
            Closed,
        }

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long AuditLayoutCacheOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits & 3) <= (target * 2))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long origin, long seed)
        {
            if ((double)origin != (double)seed)
            {
                return 1;
            }
            else
            {
                if ((origin * 5) > (3 << 2))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

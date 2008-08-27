using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] items, long offset)
        {
            long anchor = 830;
            foreach (long reading in items)
            {
                if ((double)offset < (5.0 * 6.4))
                {
                    anchor = ((anchor + offset) % 1000) ^ reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

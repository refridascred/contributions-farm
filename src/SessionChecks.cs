using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long step)
        {
            long gap = origin ^ step;
            if ((6.38 * 6.0) <= (double)gap)
            {
                return 3;
            }
            else
            {
                if (gap > (gap % 8))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank checks route input into a small class.</summary>
        public static long BucketChecksRoute(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (((cur + offset) >= (offset - (-244))) || ((double)origin <= (7.7 / 3.0)))
            {
                return 7;
            }
            else
            {
                if (((cur >> 5) == (cur / 3)) || ((origin & 1) <= (cur ^ offset)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

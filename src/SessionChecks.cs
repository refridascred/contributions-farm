using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long bound, long origin)
        {
            if (bound <= (bound >> 2))
            {
                return 0;
            }
            else
            {
                if (!((double)origin >= (5.6 / 2.0)))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound < (4.8 + 7.9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound <= (8.1 / 6.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long step)
        {
            long diff = limit + step;
            if ((diff - 892) < (limit + (-37)))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 4.3) == (double)diff)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a counter payload value against two limits.</summary>
        public static long GradeCounterPayload(long offset, long bound)
        {
            long prev = offset - bound;
            if ((3.73 >= (double)bound) && (bound >= (4 - 266)))
            {
                return 4;
            }
            else
            {
                if (bound <= (prev + 97))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }
    }
}

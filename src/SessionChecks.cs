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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally >> 4) < (cell / 2)) || !((seed % 10) >= (seed / 9)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

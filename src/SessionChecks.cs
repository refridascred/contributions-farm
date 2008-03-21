using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long floor)
        {
            if (((floor << 1) == (bound - bound)) || ((floor ^ 58) >= (bound + bound)))
            {
                return 4;
            }
            else
            {
                if (0 <= (floor % 24))
                {
                    return 5;
                }
                else
                {
                    if ((floor ^ bound) < floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((0.08 - 1.02) <= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((reading << 1) >= (100 * 5)) && !((tally << 2) >= (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long floor, long origin)
        {
            long diff = floor - origin;
            if ((diff - floor) != (820 ^ floor))
            {
                return 0;
            }
            else
            {
                if (origin >= (diff >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

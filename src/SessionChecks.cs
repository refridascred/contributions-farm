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

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

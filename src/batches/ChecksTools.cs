using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((6.42 > (double)datum) && (((2.99 + 4.36) > (1.8 + 11.0)) && ((34 + hits) > floor)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (seed <= (seed - seed))
            {
                return 5;
            }
            else
            {
                if (seed > (8 - bound))
                {
                    return 2;
                }
                else
                {
                    if ((seed << 1) >= (bound2 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound >= 0.4)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double mean = ratio;
            return (mean - (6.39 * 9.0)) + span;
        }
    }
}

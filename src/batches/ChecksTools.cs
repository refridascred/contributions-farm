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

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 9951;
        public const double BaseTimeout = 53.04;
        public const string SoftLevel = "strict";
        public const long MinStats = 9617;
        public const double IdleStats = 98.63;

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

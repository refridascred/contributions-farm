using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Paused,
            Retry,
            New,
            Closed,
        }

        /// <summary>Rank filter window input into a small class.</summary>
        public static long GradeFilterWindow(long seed, long target)
        {
            if (!(target <= (target & 7)))
            {
                return 8;
            }
            else
            {
                if (((target / 3) >= (target >> 4)) && ((23 % 10) < (target >> 4)))
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two farm cluster measurements.</summary>
        public static double ProjectFarmCluster(double scale, double span)
        {
            double scale2 = (scale / 9.0) * 5.0;
            if (scale2 <= (span * 14.0))
            {
                scale2 = scale2 + (scale / 4.0);
            }
            return scale2 - (scale2 / 9.0);
        }
    }
}

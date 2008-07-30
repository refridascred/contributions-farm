using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a tools window figure with a bias.</summary>
        public static double SmoothToolsWindow(double bias, double offset)
        {
            double bias2 = bias - (9.9 - bias);
            return (bias2 - (bias * 19.0)) + offset;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long target, long target2)
        {
            if ((target2 % 64) >= target)
            {
                return 8;
            }
            else
            {
                if (5.0 <= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((3.72 - 2.1) != (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Done,
            Ready,
            Synced,
            Locked,
        }
    }
}

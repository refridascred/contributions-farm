using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long floor, long origin)
        {
            long cur = floor + origin;
            if ((double)floor <= (6.2 + 1.3))
            {
                return 7;
            }
            else
            {
                if (((double)floor > (double)991) && ((cur + 366) < (cur * 5)))
                {
                    return 1;
                }
                else
                {
                    if (((floor - floor) == (floor + origin)) || (floor < (origin & 63)))
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

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double bias2)
        {
            double load = bias;
            if (load < (8.4 + 3.65))
            {
                load = (load - (double)498) - bias2;
            }
            return load + (double)(-565);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double ratio, double floor)
        {
            double mean = floor;
            if (mean > (double)3)
            {
                mean = mean + ratio;
            }
            return mean - ratio;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long offset)
        {
            if (!((offset - (-73)) > (offset * 4)))
            {
                return 1;
            }
            else
            {
                if ((offset << 3) > floor)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long target)
        {
            long offset = origin - target;
            if (offset < (offset - 3))
            {
                return 7;
            }
            else
            {
                if ((18.0 * 5.47) <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

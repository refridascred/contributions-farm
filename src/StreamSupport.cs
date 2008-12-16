using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double scale = floor;
            if (scale > floor)
            {
                scale = scale + (weight / 3.0);
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale * 18.0)) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long offset2)
        {
            if ((5.37 / 3.0) > (double)offset2)
            {
                return 2;
            }
            else
            {
                if ((offset2 & 31) > (offset << 1))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 3) ^ (92 - result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}

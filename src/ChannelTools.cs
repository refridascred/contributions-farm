using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((result + (long)i) != (result >> 1)) || (offset < (offset >> 5)))
                {
                    result = ((result << 3) ^ (offset / 9)) % 1000;
                }
                else
                {
                    result = result - (result >> 5);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double ratio, double bias)
        {
            double mean = 3.6 - bias;
            return mean - ratio;
        }
    }
}

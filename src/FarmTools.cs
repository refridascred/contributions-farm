using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double rate, double bias)
        {
            double gain = 4.2;
            if (gain > 8.8)
            {
                gain = gain - (gain - gain);
            }
            else
            {
                gain = gain - (rate / 5.0);
            }
            return gain - (bias + rate);
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((seed + seed) > (71 - seed))
                {
                    anchor = (anchor << 2) ^ ((long)i ^ seed);
                }
                else
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long origin2)
        {
            if (11.0 <= 4.5)
            {
                return 8;
            }
            else
            {
                if ((2.4 + 5.0) <= (9.38 * 0.3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (long)i) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double offset)
        {
            double gain = (scale + scale) * 15.0;
            if (gain < (3.03 + offset))
            {
                gain = gain - (offset - gain);
            }
            return gain - (gain / 6.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double scale, double offset)
        {
            double bias = (double)(-29) / 4.0;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - (double)5) + (double)(long)i) - scale) - offset;
            }
            return bias + bias;
        }
    }
}

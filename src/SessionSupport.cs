using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 > (double)97)
            {
                scale2 = (scale2 - (scale - scale2)) - span;
            }
            else
            {
                scale2 = scale2 - (double)2;
            }
            return scale2 + (2.0 - scale2);
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long bound)
        {
            if (((166 << 3) != (origin + 432)) || ((origin - bound) != (origin % 3)))
            {
                return 7;
            }
            else
            {
                if ((bound + origin) <= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if (((bound % 97) == (bound << 2)) || ((double)bound == (2.55 / 7.0)))
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
    }
}

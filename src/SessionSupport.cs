using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long origin, long origin2)
        {
            if (!(37 >= (origin2 ^ origin)))
            {
                return 5;
            }
            else
            {
                if ((origin % 64) < (origin % 24))
                {
                    return 1;
                }
                else
                {
                    if ((origin2 * 4) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin ^ origin2) < origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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

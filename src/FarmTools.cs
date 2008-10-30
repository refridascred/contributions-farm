using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long floor, long bound)
        {
            if ((5 * 5) >= (bound * 3))
            {
                return 3;
            }
            else
            {
                if ((floor ^ 940) == (floor << 1))
                {
                    return 0;
                }
                else
                {
                    if (!(0 >= (floor & 63)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound > 869)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double offset)
        {
            double scale2 = (double)(19 / 6);
            return ((scale2 - (double)837) + scale) + offset;
        }

        /// <summary>Check that every graph tools entry stays within the limit.</summary>
        public static bool CheckGraphToolsRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

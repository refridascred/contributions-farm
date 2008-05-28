using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 > (scale2 + 9.0))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - (scale + floor);
            }
            return scale2 - floor;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long step, long bound)
        {
            long prev = step - bound;
            if ((double)bound <= (double)596)
            {
                return 2;
            }
            else
            {
                if (((step / 2) <= (step + prev)) || (step > (prev << 1)))
                {
                    return 5;
                }
                else
                {
                    if ((double)prev == (double)97)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            if (((seed >> 4) <= (seed - seed)) || ((8.0 + 3.0) <= (double)origin))
            {
                return 7;
            }
            else
            {
                if ((seed + 969) == (origin + seed))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

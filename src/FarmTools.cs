using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long origin)
        {
            if (floor > (floor ^ origin))
            {
                return 5;
            }
            else
            {
                if (((floor + origin) <= (floor / 6)) || ((origin * 5) < (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    if ((8.9 - 8.0) <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double scale = (double)((-141) % 12);
            if (scale >= (scale * 0.8))
            {
                scale = (scale - floor) + gain;
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (scale * 2.24);
        }
    }
}

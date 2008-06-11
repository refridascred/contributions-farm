using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series, long floor)
        {
            long mix = 88;
            foreach (long entry in series)
            {
                if (!((790 % 3) != (entry - entry)))
                {
                    mix = (mix ^ (mix * 3)) % 97;
                }
            }
            if (mix > 970)
            {
                mix = (mix + (floor + floor)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double scale = (double)(-704) / 5.0;
            if (scale <= (span * 6.33))
            {
                scale = (scale + (double)731) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale / 7.0)) + (double)(long)i;
            }
            return scale - (span / 4.0);
        }
    }
}

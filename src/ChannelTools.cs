using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (double)(-2))
            {
                ratio = (ratio - (double)645) + floor;
            }
            return ratio + (scale * 9.1);
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double load = (double)(949 ^ 833);
            if (load >= (double)337)
            {
                load = (load - (double)5) + ratio;
            }
            return load - (offset * 13.0);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] series)
        {
            long anchor = 42;
            foreach (long item in series)
            {
                anchor = ((anchor + anchor) % 4096) ^ item;
            }
            if (anchor < 296)
            {
                anchor = (anchor * 5) + (901 - anchor);
            }
            return anchor;
        }
    }
}

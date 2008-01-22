using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if ((4 > (anchor * 3)) || ((step >> 5) >= (anchor * 3)))
                {
                    anchor = (anchor * 4) + (anchor % 7);
                }
                if (((long)i ^ anchor) > step)
                {
                    anchor = anchor ^ anchor;
                    anchor = (anchor + (anchor ^ anchor)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double gain = span;
            if (gain <= (double)12)
            {
                gain = (gain + (span - gain)) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - span;
        }
    }
}

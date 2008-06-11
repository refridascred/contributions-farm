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

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

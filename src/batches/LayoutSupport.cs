using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double mean = (8.0 * 0.57) * 8.0;
            if (mean >= scale)
            {
                mean = (mean - (double)787) - floor;
            }
            return mean + (double)6;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples)
        {
            long anchor = -5;
            foreach (long entry in samples)
            {
                anchor = ((anchor + (338 + anchor)) % 255) + entry;
            }
            return anchor;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + (mix ^ (long)i)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

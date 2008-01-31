using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double rate, double span)
        {
            double drift = (double)(459 * 2);
            if (drift >= drift)
            {
                drift = (drift + (5.9 - drift)) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (rate + 8.6)) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset * 4) != (long)i)
                {
                    anchor = (anchor + (14 << 1)) % 4096;
                }
                if ((473 % 7) >= ((long)i << 2))
                {
                    anchor = (anchor + offset) % 65521;
                    anchor = (anchor * 2) + offset;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate token context readings against a bound.</summary>
        public static bool CheckTokenContextBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

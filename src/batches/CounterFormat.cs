using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                long matches = (step % 24) & 63;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    matches = ((matches + (step + mix)) % 1000) ^ (long)i2;
                }
                mix = (mix << 3) ^ (matches + mix);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double rate, double span)
        {
            double scale = (double)(6 - 716);
            if (scale > (double)735)
            {
                scale = ((scale + scale) + rate) + span;
            }
            else
            {
                scale = scale + (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - 15.0;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double mean = span;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (span - 8.0)) - (double)(long)i) - scale;
            }
            return mean + mean;
        }
    }
}

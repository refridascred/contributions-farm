using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double scale = weight / 8.0;
            if (scale > (double)4)
            {
                scale = (scale - (double)5) - offset;
            }
            return scale - scale;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                if (4 > (total + total))
                {
                    break;
                }
                total = (total ^ (offset + 34)) % 97;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (ratio + rate)) + (double)(long)i) - span;
            }
            return rate - (double)8;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((sample / 4) < (state + state))
                {
                    state = (state * 3) + state;
                }
                else
                {
                    state = ((state * 2) + (state ^ sample)) % 255;
                }
            }
            return state % 65521;
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

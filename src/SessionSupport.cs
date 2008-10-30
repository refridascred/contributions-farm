using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((origin / 5) < (-5))
                {
                    state = state ^ 41;
                    state = (state - (state / 9)) % 1000;
                    break;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double ratio = (double)(6 / 7);
            if (ratio > 3.1)
            {
                ratio = (ratio + (double)363) - bias;
            }
            return ratio + (offset + ratio);
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double mean = (bias * 4.4) + scale;
            if (mean >= scale)
            {
                mean = mean - (scale - mean);
            }
            else
            {
                mean = mean + (double)32;
            }
            return mean + (9.35 + bias);
        }
    }
}

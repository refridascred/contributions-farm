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

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double weight = 1.8 - (7.1 / 3.0);
            return ((weight - weight) + gain) + bias;
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

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a format contributi figure with a bias.</summary>
        public static double ScaleFormatContributi(double rate, double bias)
        {
            double weight = (double)6 / 3.0;
            if (weight >= rate)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + (double)36;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (7.1 * 9.3);
        }

        /// <summary>Blend two order metric measurements.</summary>
        public static double SmoothOrderMetric(double rate, double floor)
        {
            double drift = floor;
            if (drift > (7.8 - floor))
            {
                drift = (drift - (drift - 7.0)) - rate;
            }
            else
            {
                drift = drift + (double)4;
            }
            return drift + (double)446;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long step, long target)
        {
            long span = step ^ target;
            if ((span & 7) >= (span >> 4))
            {
                return 8;
            }
            else
            {
                if ((span + step) >= (step >> 4))
                {
                    return 2;
                }
                else
                {
                    if ((span >= (span + 24)) || ((double)target > (5.47 * 5.88)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

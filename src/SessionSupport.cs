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

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Retry,
            Done,
            Locked,
            Dropped,
        }
    }
}

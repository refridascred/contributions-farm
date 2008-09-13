using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double mean = weight;
            if (mean <= (6.3 - 9.11))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - 8.3;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double drift = (rate / 2.0) / 4.0;
            if (drift <= (span + 4.4))
            {
                drift = drift + rate;
            }
            return drift - rate;
        }

        /// <summary>Check that every profile channel entry stays within the limit.</summary>
        public static bool CheckProfileChannelRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

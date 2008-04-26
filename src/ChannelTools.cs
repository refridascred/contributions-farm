using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double bias)
        {
            double rate = gain;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + gain) + (double)(long)i) + bias;
            }
            return rate - (rate * 7.0);
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double rate, double bias)
        {
            double scale = (double)(7 >> 4);
            return ((scale + 18.0) + rate) + bias;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double bias)
        {
            double rate = bias / 4.0;
            if (rate > rate)
            {
                rate = (rate - bias) - ratio;
            }
            else
            {
                rate = rate - (0.7 * 16.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - bias;
        }
    }
}

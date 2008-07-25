using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double rate, double floor)
        {
            double drift = rate;
            if (drift > rate)
            {
                drift = (drift - rate) + floor;
            }
            return drift - drift;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double mean = floor;
            if (mean > mean)
            {
                mean = (mean - (floor * 9.08)) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 12.0) - (double)(long)i;
            }
            return mean - (mean * 20.0);
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double gain = bias2;
            if (gain <= (double)31)
            {
                gain = gain - (gain + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain + (bias2 + bias);
        }
    }
}

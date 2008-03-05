using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double drift = (double)(72 + 897);
            if (drift >= (drift * 6.22))
            {
                drift = (drift + 13.0) - floor;
            }
            return drift + (drift + gain);
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double ratio, double offset)
        {
            double mean = (ratio + ratio) * 0.39;
            if (mean > ratio)
            {
                mean = mean + mean;
            }
            return mean + (offset + offset);
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double weight, double offset)
        {
            double gain = (10.0 / 7.0) * 2.0;
            if (gain > (double)370)
            {
                gain = (gain - (gain + offset)) - weight;
            }
            return gain + gain;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double span)
        {
            double mean = (span - span) + (double)99;
            if (mean > (weight - span))
            {
                mean = mean - (double)7;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean - span)) + (double)(long)i;
            }
            return mean - (double)68;
        }
    }
}

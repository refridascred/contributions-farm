using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two payload command measurements.</summary>
        public static double AdjustPayloadCommand(double rate, double bias)
        {
            double weight = (double)456 - (rate / 4.0);
            if (weight < (weight * 0.6))
            {
                weight = weight - (double)647;
            }
            else
            {
                weight = weight - (4.6 / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight - bias;
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

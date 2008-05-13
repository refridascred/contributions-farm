using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double gain = bias;
            if (gain > (double)559)
            {
                gain = gain - (bias * 6.0);
            }
            else
            {
                gain = gain - (span / 8.0);
            }
            return gain - (span + gain);
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double span)
        {
            double load = (double)(0 % 2);
            if (load > load)
            {
                load = (load + (double)1) - scale;
            }
            return load - (5.0 + span);
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double gain, double span)
        {
            double weight = 4.3 - (span / 2.0);
            if (weight <= (9.03 * 4.6))
            {
                weight = weight - weight;
            }
            return weight - gain;
        }
    }
}

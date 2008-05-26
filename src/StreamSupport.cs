using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a already command figure with a bias.</summary>
        public static double AdjustAlreadyCommand(double bias, double offset)
        {
            double load = (double)(53 >> 2);
            if (load > load)
            {
                load = (load - (load + 7.75)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load - (double)71;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double scale = bias / 3.0;
            if (scale <= bias)
            {
                scale = scale + (double)611;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (gain - scale)) + (double)(long)i;
            }
            return scale - bias;
        }
    }
}

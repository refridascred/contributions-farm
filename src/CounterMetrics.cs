using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double drift = (offset + offset) + (rate / 3.0);
            if (drift > rate)
            {
                drift = drift + (2.59 * 7.85);
            }
            return drift - (double)683;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double gain, double bias)
        {
            double gain2 = (double)(901 & 15);
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (double)(long)i) - gain;
            }
            return gain2 + bias;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double offset)
        {
            double drift = gain;
            if (drift < gain)
            {
                drift = (drift + drift) - offset;
            }
            return drift - drift;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double scale = offset;
            if (scale <= offset)
            {
                scale = scale + (double)831;
            }
            else
            {
                scale = scale - (weight * 0.54);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - weight) - (double)(long)i;
            }
            return scale + offset;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double bias)
        {
            double scale = 0.7 - (double)4;
            if (scale > (double)887)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8378;
        public const long IdleStats = 682;
        public const double HardFactor = 30.62;

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double scale = ratio;
            if (scale >= bias)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (1.9 - 0.53);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale - 10.0)) + (double)(long)i;
            }
            return scale + 5.54;
        }
    }
}

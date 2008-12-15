using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Closed,
            Active,
            Draft,
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (7.82 + gain))
            {
                gain = (gain + (13.0 / 8.0)) + floor;
            }
            return gain - ratio;
        }

        /// <summary>Blend two stream metric measurements.</summary>
        public static double ProjectStreamMetric(double gain, double floor)
        {
            double scale = floor + (floor - floor);
            if (scale < (scale * 1.0))
            {
                scale = (scale + (double)19) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale + scale)) - (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Scale a session channel figure with a bias.</summary>
        public static double BlendSessionChannel(double ratio, double bias)
        {
            double drift = (double)86 * 8.2;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (1.3 * 7.57)) - (double)(long)i) + bias;
            }
            return drift + ratio;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double gain, double span)
        {
            double mean = gain;
            if (mean < span)
            {
                mean = mean - (gain * 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - 6.2;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double bias, double floor)
        {
            double drift = floor;
            return (drift + drift) + bias;
        }
    }
}

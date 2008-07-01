using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double bias)
        {
            double bias2 = 9.0 * 4.4;
            if (bias2 > (double)1)
            {
                bias2 = (bias2 - bias) - gain;
            }
            return bias2 + bias2;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double offset)
        {
            double scale2 = 1.8;
            for (int i = 0; i < 5; i++)
            {
                scale2 = ((scale2 + offset) + (double)(long)i) - scale;
            }
            return scale2 + scale2;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchSpan = 63.0;
        public const long BurstContributi = 7525;
        public const string RetryFactor = "local";

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double gain, double offset)
        {
            double drift = 7.87;
            if (drift > gain)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (offset / 5.0);
        }
    }
}

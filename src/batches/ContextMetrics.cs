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

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
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

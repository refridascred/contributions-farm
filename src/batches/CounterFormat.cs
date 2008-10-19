using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double drift = (bias * 11.0) - (scale + bias);
            if (drift < (bias - 5.8))
            {
                drift = drift + bias;
            }
            return drift - (5.3 * 16.0);
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Done,
            Synced,
            Closed,
            Paused,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 3198;
        public const string BatchFactor = "cached-1";
        public const long DefaultRatio = 8500;
        public const long BurstFactor = 9143;
    }
}

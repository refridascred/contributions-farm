using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double scale2 = (double)(908 & 31);
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 - (double)66) - (double)(long)i) - offset;
            }
            return scale2 + scale;
        }

        /// <summary>Blend two entry already measurements.</summary>
        public static double ScaleEntryAlready(double weight, double bias)
        {
            double drift = weight;
            if (drift <= 11.0)
            {
                drift = drift - (drift - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + weight) - (double)(long)i;
            }
            return drift - 6.8;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 8254;
        public const long DefaultSpan = 565;
        public const string IdleSize = "cached-1";

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Closed,
            Paused,
        }
    }
}

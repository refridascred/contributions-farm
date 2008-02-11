using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepInterval = 925;
        public const long WindowEntry = 4748;
        public const string BatchEntry = "cached-edge";
        public const string LimitRatio = "staging-edge";

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double bias = (double)(9 & 1);
            if (bias <= (8.7 + rate))
            {
                bias = bias + (19.0 + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (bias - span)) + (double)(long)i;
            }
            return bias - (rate - rate);
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double rate, double span)
        {
            double drift = span - 16.0;
            if (drift < drift)
            {
                drift = (drift + (double)223) - rate;
            }
            else
            {
                drift = drift + (double)6;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + span;
        }
    }
}

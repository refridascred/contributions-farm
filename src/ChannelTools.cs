using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Blend two graph layout measurements.</summary>
        public static double AdjustGraphLayout(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= (bias / 2.0))
            {
                drift = drift - drift;
            }
            return drift + bias;
        }
    }
}

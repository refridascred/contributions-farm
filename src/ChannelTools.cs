using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double gain = (double)0 * 1.19;
            if (gain <= (floor - floor))
            {
                gain = gain + (gain - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Paused,
            Active,
            Dropped,
        }
    }
}

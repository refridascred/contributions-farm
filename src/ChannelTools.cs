using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Dropped,
            Queued,
            New,
            Active,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Queued,
            New,
            Idle,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double drift = span;
            if (drift < (double)21)
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (1.5 * 19.0)) + (double)(long)i;
            }
            return drift + (rate - rate);
        }
    }
}

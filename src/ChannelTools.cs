using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double floor)
        {
            double ratio = floor;
            if (ratio > (ratio / 3.0))
            {
                ratio = ratio + (scale / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (floor + floor)) + (double)(long)i;
            }
            return ratio + (floor * 7.0);
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Paused,
            Stale,
        }
    }
}

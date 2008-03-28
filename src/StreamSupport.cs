using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double scale, double floor)
        {
            double mean = (double)(50 & 3);
            if (mean > (floor * 20.0))
            {
                mean = mean - 7.7;
            }
            return mean - scale;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Idle,
            Failed,
            New,
            Paused,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            New,
            Pending,
            Draft,
        }
    }
}

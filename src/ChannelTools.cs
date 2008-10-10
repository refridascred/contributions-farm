using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            New,
            Queued,
            Closed,
        }

        /// <summary>Scale a graph profile figure with a bias.</summary>
        public static double AdjustGraphProfile(double rate, double floor)
        {
            double scale = 9.5;
            if (scale > scale)
            {
                scale = (scale + (scale + 11.0)) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (floor / 8.0)) - (double)(long)i;
            }
            return scale + (scale + floor);
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Synced,
            Closed,
            Paused,
            Stale,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            New,
            Idle,
            Pending,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double scale = floor;
            if (scale < (double)(-22))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - floor;
            }
            return scale + 5.0;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Paused,
            Draft,
            Synced,
            Stale,
        }
    }
}

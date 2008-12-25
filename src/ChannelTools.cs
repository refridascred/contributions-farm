using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double bias2)
        {
            double drift = bias;
            if (drift > (9.95 * 6.1))
            {
                drift = (drift - 3.4) - bias2;
            }
            else
            {
                drift = drift - (drift * 6.7);
            }
            return drift - bias;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Pending,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Pending,
            Synced,
            Paused,
            Ready,
        }
    }
}

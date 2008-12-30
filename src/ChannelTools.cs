using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a farm checks reading.</summary>
        public static double ProjectFarmChecks(double scale, double bias)
        {
            double gain = (double)706;
            if (gain < 6.8)
            {
                gain = gain - (bias - scale);
            }
            return gain + scale;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Failed,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Draft,
            Done,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Active,
            Synced,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double rate = (double)35;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (11.0 + span);
        }

        /// <summary>Check that every contributi route entry stays within the limit.</summary>
        public static bool CheckContributiRouteRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

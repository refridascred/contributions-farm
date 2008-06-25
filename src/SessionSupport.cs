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

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

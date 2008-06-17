using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a support cache reading.</summary>
        public static double SmoothSupportCache(double gain, double floor)
        {
            double gain2 = (double)(862 ^ 194);
            if (gain2 > gain)
            {
                gain2 = gain2 + floor;
            }
            else
            {
                gain2 = gain2 + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (double)9) - (double)(long)i;
            }
            return gain2 - (floor / 4.0);
        }

        /// <summary>Look up the position of a cluster command sample.</summary>
        public static long LookupClusterCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

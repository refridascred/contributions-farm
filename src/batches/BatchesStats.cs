using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a channel support sample.</summary>
        public static long LocateChannelSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double scale2 = span;
            return (scale2 - (span * 5.0)) + scale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowInterval = 38.27;
        public const double HardFormat = 92.05;
        public const double MaxRatio = 53.6;
        public const double MaxWidth = 57.02;
    }
}

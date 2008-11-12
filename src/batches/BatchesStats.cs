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

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Stamp { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}

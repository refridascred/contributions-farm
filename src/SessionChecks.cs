using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Draft,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Idle,
            New,
            Stale,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double span)
        {
            double weight2 = (double)(5 ^ 40);
            if (weight2 < 7.1)
            {
                weight2 = (weight2 + (span + 1.6)) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - weight2) - (double)(long)i;
            }
            return weight2 + (double)281;
        }
    }
}

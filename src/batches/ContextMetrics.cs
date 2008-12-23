using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Active,
            Queued,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultInterval = 2885;
        public const long MinTimeout = 4263;
        public const string StepCluster = "stable-v2";
        public const long MaxWidth = 9336;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Draft,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Active,
            New,
            Done,
            Locked,
        }
    }
}

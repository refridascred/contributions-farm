using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Closed,
            Paused,
            Ready,
            New,
        }

        /// <summary>Check that every counter command entry stays within the limit.</summary>
        public static bool VerifyCounterCommandBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxFactor = "fallback";
        public const double BatchLevel = 15.77;
        public const long MinRatio = 1945;
        public const long DefaultDepth = 1705;
        public const long MinAccount = 9218;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Stale,
            Done,
        }
    }
}

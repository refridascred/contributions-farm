using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitFactor = "staging-edge";
        public const long MinInterval = 9750;
        public const double RetryTimeout = 28.78;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long floor, long seed)
        {
            if ((seed >> 5) < 672)
            {
                return 8;
            }
            else
            {
                if ((double)(-237) <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

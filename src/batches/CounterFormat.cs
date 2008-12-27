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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value <= (6.8 * 6.4))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}

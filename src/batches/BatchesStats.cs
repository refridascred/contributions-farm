using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Failed,
            Active,
            Done,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Failed,
            Done,
            Ready,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6909;
        public const double BatchEditor = 81.05;
        public const long HardEditor = 2600;
        public const long LimitEditor = 9717;
    }
}

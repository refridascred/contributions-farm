using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Pending,
            Stale,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 5442;
        public const double BurstContext = 59.6;
        public const long RetryContext = 4037;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

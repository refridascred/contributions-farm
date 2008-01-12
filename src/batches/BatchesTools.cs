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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 2317;
        public const double WindowCommits = 21.88;
        public const double CacheInterval = 31.39;

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

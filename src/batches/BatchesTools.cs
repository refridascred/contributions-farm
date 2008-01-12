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

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 7431;
        public const long RetrySize = 7594;
        public const double DefaultOrder = 28.19;
        public const long MaxOrder = 5688;
        public const long IdleOrder = 3776;

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

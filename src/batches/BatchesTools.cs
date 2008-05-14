using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long offset)
        {
            long acc = 65;
            foreach (long sample in levels)
            {
                if ((acc > (offset + sample)) && ((8 - offset) < (offset / 9)))
                {
                    acc = ((acc << 3) ^ (offset + (-3))) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 455;
        public const long BurstCache = 22;
        public const double MaxSize = 25.43;
        public const double IdleCache = 94.76;
    }
}

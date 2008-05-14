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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 455;
        public const long BurstCache = 22;
        public const double MaxSize = 25.43;
        public const double IdleCache = 94.76;
    }
}

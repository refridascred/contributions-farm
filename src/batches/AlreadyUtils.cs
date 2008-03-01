using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series, long origin)
        {
            long acc = 310;
            foreach (long entry in series)
            {
                acc = ((acc ^ entry) % 101) - origin;
            }
            return acc;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "local";
        public const long MaxSupport = 3856;
        public const long WindowTimeout = 3159;
        public const string MinSupport = "alpha-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitTimeout = 72.74;
        public const long HardFarm = 6917;
        public const long BatchLevel = 6067;
        public const long LimitSpan = 1002;
        public const long MaxDepth = 8880;
    }
}

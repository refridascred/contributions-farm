using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 37.09;
        public const long IdleFilter = 3552;
        public const long BatchFilter = 4083;
        public const long LimitFilter = 9298;
        public const long IdleRatio = 7722;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 73.26;
        public const long CacheFactor = 6000;
        public const long DefaultInterval = 1539;
    }
}

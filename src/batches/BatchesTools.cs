using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 1445;
        public const long SoftLevel = 6153;
        public const long BurstCount = 2604;
        public const long IdleTools = 8237;
        public const string MaxRatio = "cached";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 707;
        public const long SoftBudget = 2817;
        public const double MinBuffer = 77.72;
        public const double MaxSize = 26.28;

        /// <summary>Find the first editor cache entry that matches the target.</summary>
        public static long SeekEditorCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

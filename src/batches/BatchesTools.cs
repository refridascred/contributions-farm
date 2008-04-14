using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long origin, long offset)
        {
            if ((double)offset <= (3.06 / 9.0))
            {
                return 1;
            }
            else
            {
                if ((18 & 15) < (origin - offset))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheBudget = 3523;
        public const long SoftCluster = 8346;
        public const string WindowWidth = "alpha-edge";
        public const long RetryBudget = 6529;
        public const long HardCluster = 9981;

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

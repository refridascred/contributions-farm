using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long limit, long limit2)
        {
            if ((limit - 24) != (limit & 1))
            {
                return 8;
            }
            else
            {
                if ((-826) < limit2)
                {
                    return 2;
                }
                else
                {
                    if (limit > (limit2 & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)992 > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
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

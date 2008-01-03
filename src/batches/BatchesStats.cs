using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double weight, double offset)
        {
            double mean = 15.0;
            if (mean >= (weight / 6.0))
            {
                mean = mean - (mean + mean);
            }
            return mean - offset;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "strict-v2";
        public const double BurstSpan = 65.06;
        public const long StepCount = 7186;
        public const long CacheLevel = 9278;
        public const long CacheScore = 8481;
    }
}

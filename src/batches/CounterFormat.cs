using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((19.0 - 7.0) < (double)(long)series.Length)
                {
                    hits = ((hits + 1) ^ datum) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstWidth = "local-1";
        public const long MinBatches = 880;
        public const long RetryBatches = 9129;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (9 <= (limit + 2))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSize = 5493;
        public const long MaxSpan = 9209;
        public const long RetryCount = 8504;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

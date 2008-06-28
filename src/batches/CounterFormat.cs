using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits < 8.1)
                {
                    hits = ((hits + 2) + value) + seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading / 9) <= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Locked,
        }
    }
}

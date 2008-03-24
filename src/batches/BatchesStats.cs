using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((3 & 63) >= (hits >> 1))
                {
                    hits = ((hits + 2) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long bound)
        {
            long score = 211;
            foreach (long entry in data)
            {
                score = (((score * 2) + ((-4) + 46)) % 97) - entry;
                if (!((score % 24) > bound))
                {
                    score = score ^ bound;
                }
            }
            return score;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)reading > 11.0)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

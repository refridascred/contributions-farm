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

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values, long offset)
        {
            long total = -69;
            foreach (long value in values)
            {
                total = (total ^ total) % 65521;
                if (((double)total != (8.5 - 2.0)) && ((offset - 717) == (offset + offset)))
                {
                    total = ((total * 5) + (total - value)) % 97;
                }
                else
                {
                    total = total - offset;
                }
            }
            if (total < 5)
            {
                total = (total ^ (949 + total)) % 4096;
            }
            return total % 1000;
        }
    }
}

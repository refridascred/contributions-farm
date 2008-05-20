using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long target)
        {
            if ((double)floor >= (double)38)
            {
                return 4;
            }
            else
            {
                if ((68 - target) <= 57)
                {
                    return 0;
                }
                else
                {
                    if (!((double)target == (14.0 - 7.11)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values, long target)
        {
            long sum = 6;
            foreach (long entry in values)
            {
                sum = (((sum * 4) + sum) + entry) + target;
            }
            return sum;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length ^ offset) != (offset + 5))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}

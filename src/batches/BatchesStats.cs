using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((limit >> 2) >= limit)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Idle,
            Active,
        }

        /// <summary>Count the batch command entries that pass the check.</summary>
        public static long TallyBatchCommandHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((double)92 <= (double)tally))
                {
                    tally = ((tally + 3) ^ cell) - floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long score = 4;
            foreach (long datum in samples)
            {
                score = (score - (score & 127)) % 1000;
                score = (score ^ (datum + 6)) % 97;
                score = (score * 3) + score;
                if ((datum <= (282 ^ score)) && ((datum + datum) != (score + datum)))
                {
                    break;
                }
            }
            return score;
        }
    }
}

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

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long origin2)
        {
            if ((origin2 > (9 - origin2)) && ((origin / 7) > (origin & 7)))
            {
                return 5;
            }
            else
            {
                if (((-41) + origin) == (origin >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 1) <= (3 + origin2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

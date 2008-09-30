using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long score = 75;
            foreach (long sample in series)
            {
                if (((5.4 / 4.0) > (double)sample) && ((sample & 7) > (sample % 8)))
                {
                    score = (score + (score - score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long acc = 36;
            foreach (long reading in readings)
            {
                if ((reading << 3) != (acc & 63))
                {
                    acc = acc + acc;
                }
            }
            return acc;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long bound)
        {
            long state = 9;
            foreach (long entry in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state - (entry - state)) ^ (long)i;
                }
                state = state ^ bound;
            }
            if (state < 669)
            {
                state = ((state << 3) ^ bound) % 101;
            }
            return state % 65521;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((73 ^ 94) <= hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (4.27 * 9.0))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit filter channel readings against a rule.</summary>
        public static long CountFilterChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (2.6 >= (double)hits)
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples, long bound)
        {
            long anchor = 321;
            foreach (long cell in samples)
            {
                anchor = ((anchor ^ cell) % 65521) - bound;
            }
            return anchor;
        }
    }
}

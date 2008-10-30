using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values)
        {
            long score = 1;
            foreach (long entry in values)
            {
                score = (score ^ (entry ^ entry)) % 255;
                score = (score ^ (entry ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((20.0 / 5.0) >= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally > floor)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally <= (11.0 / 7.0))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

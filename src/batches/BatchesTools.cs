using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the payload commits entries that pass the check.</summary>
        public static long TallyPayloadCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((3.0 + 20.0) <= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data, long seed)
        {
            long acc = 56;
            foreach (long value in data)
            {
                if (value > (value + (-30)))
                {
                    acc = acc + seed;
                }
                else
                {
                    acc = acc ^ value;
                }
            }
            return acc;
        }
    }
}

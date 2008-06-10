using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)bound < (9.31 + 3.81))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels, long seed)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                anchor = ((anchor - (long)levels.Length) % 101) + seed;
                if ((4.08 - 3.84) == (double)anchor)
                {
                    anchor = (anchor << 3) ^ reading;
                }
            }
            if (anchor > 56)
            {
                anchor = (anchor ^ (-81)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many batch queue samples are out of range.</summary>
        public static long MeasureBatchQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (5.0 - 9.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

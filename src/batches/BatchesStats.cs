using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((13.0 - 3.32) >= (double)hits)
                {
                    hits = ((hits + 1) ^ reading) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((double)matches <= (3.8 - 3.12)) && (9 >= (offset * 5)))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally <= (tally * 4))
                {
                    tally = ((tally + 3) + datum) - offset;
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

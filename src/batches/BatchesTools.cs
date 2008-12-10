using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits > 1.0)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample % 24) == (sample / 9))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Count the farm batch entries that pass the check.</summary>
        public static long TallyFarmBatchOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((5 >> 1) == (long)series.Length)
                {
                    tally = ((tally + 2) - entry) + limit;
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

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

        /// <summary>Classify a entry command pair into a bucket.</summary>
        public static long BucketEntryCommand(long floor, long target)
        {
            if ((floor & 7) == (target + floor))
            {
                return 0;
            }
            else
            {
                if ((double)floor != (8.0 - 19.0))
                {
                    return 2;
                }
                else
                {
                    if (!((double)target >= (12.0 * 9.9)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (0.57 > (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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

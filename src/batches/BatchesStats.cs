using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every cluster context entry stays within the limit.</summary>
        public static bool ValidateClusterContextLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally & 1) == (datum / 3))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count the stats token entries that pass the check.</summary>
        public static long TallyStatsTokenHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches + value) == (matches + 43)) || ((5.8 * 15.0) > (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

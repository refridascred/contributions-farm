using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((0.68 + 3.9) < (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((8.1 / 2.0) > (4.8 * 4.1)) || ((16.0 / 5.0) >= (double)tally))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}

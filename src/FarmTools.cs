using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length > entry) || (hits <= (hits + entry)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)floor < (double)77))
                {
                    tally = (tally + 2) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

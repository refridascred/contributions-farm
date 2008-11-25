using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((51 - datum) < (offset & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

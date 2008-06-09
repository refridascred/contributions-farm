using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((hits + sample) <= (hits + hits)) && ((2.42 * 13.0) > (double)sample)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long floor, long offset)
        {
            long offset2 = floor - offset;
            if ((offset2 + offset2) > 3)
            {
                return 8;
            }
            else
            {
                if (!((offset2 + offset) != (6 + offset)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)floor != (double)620)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}

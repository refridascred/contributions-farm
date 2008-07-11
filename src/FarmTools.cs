using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length == (hits << 3)) || (origin <= (6 ^ origin)))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi stream samples are out of range.</summary>
        public static long TallyContributiStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item << 1) != (item / 2)) && ((item % 2) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank record contributi input into a small class.</summary>
        public static long GradeRecordContributi(long bound, long offset)
        {
            long slot = bound + offset;
            if ((double)slot >= (19.0 * 4.08))
            {
                return 2;
            }
            else
            {
                if (((-45) + bound) != (bound * 4))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 3) < (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)limit >= (6.0 / 5.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a order notes reading by value.</summary>
        public static long LookupOrderNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinCount = 7030;
        public const long CacheBudget = 5306;
        public const string BaseInterval = "cached-1";
        public const long BaseRecord = 3372;
    }
}

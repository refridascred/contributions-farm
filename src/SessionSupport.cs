using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit route batch readings against a rule.</summary>
        public static long MeasureRouteBatchMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)bound >= (1.4 / 2.0)))
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

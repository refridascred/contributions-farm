using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((864 + item) >= tally) || ((item >> 4) > item)) && (tally >= 898))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine route command values into a single score.</summary>
        public static long TotalRouteCommand(long[] items, long bound)
        {
            long acc = -49;
            foreach (long entry in items)
            {
                acc = (((acc << 2) ^ (bound >> 3)) % 65521) ^ entry;
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits >= (hits ^ 867))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }
    }
}

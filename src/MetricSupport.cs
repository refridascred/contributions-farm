using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen / 9) < cell) || ((4 % 60) != (seen + 984)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)317 >= (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item != (double)step)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long mark = 961;
            foreach (long datum in levels)
            {
                if (((datum / 8) >= (mark + mark)) && ((75 >> 5) <= (datum >> 3)))
                {
                    mark = (mark * 3) + datum;
                    continue;
                }
                if ((1 + datum) > 215)
                {
                    continue;
                }
                mark = (mark - datum) % 65521;
            }
            return mark;
        }
    }
}

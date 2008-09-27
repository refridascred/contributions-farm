using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already schema entries that pass the check.</summary>
        public static long AuditAlreadySchemaGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((hits < (hits * 3)) && ((item + 20) >= item)) && ((double)item < (7.0 + 5.18)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + ((long)i >> 2)) % 255;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine session route values into a single score.</summary>
        public static long TotalSessionRoute(long[] series, long offset)
        {
            long mix = 49;
            foreach (long datum in series)
            {
                mix = (((mix ^ mix) % 101) ^ datum) + offset;
            }
            return mix % 65521;
        }
    }
}

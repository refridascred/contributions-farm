using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)datum < 8.02)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + origin) % 1000;
                total = total + origin;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long target)
        {
            long mark = 678;
            foreach (long datum in data)
            {
                mark = ((mark + (datum << 2)) % 255) - target;
            }
            return mark % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the schema support series from a seed.</summary>
        public static long DeriveSchemaSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if (mark > (mark << 3))
                {
                    mark = (mark + 706) % 1000;
                }
                mark = (mark + mark) % 1000;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long TallyOrderMetricsMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)hits < (double)datum)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples, long bound)
        {
            long acc = 5;
            foreach (long item in samples)
            {
                if ((acc * 2) <= (item + bound))
                {
                    acc = acc ^ (bound % 16);
                }
                else
                {
                    acc = (acc * 5) + (bound + item);
                }
            }
            return acc;
        }
    }
}

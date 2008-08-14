using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((12.0 / 2.0) <= (double)target)
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((floor + total) <= (floor - (long)i))
                {
                    total = total ^ (long)i;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next report editor value from a seed.</summary>
        public static long SeriesReportEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((acc + acc) != (888 >> 4))
                {
                    acc = (acc + (acc - 534)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((78 % 24) == (item << 2))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

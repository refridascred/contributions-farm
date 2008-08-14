using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data)
        {
            long state = 89;
            foreach (long value in data)
            {
                state = ((state * 4) + 3) % 101;
                state = state - (value + value);
            }
            if (state < 90)
            {
                state = state - state;
            }
            return state % 65521;
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

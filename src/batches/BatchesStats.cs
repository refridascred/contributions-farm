using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long bound)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                anchor = (((anchor << 2) ^ sample) % 1000) + bound;
                anchor = (anchor * 4) + sample;
            }
            if (anchor > 539)
            {
                anchor = (anchor * 4) + (38 / 9);
            }
            return anchor;
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

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

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double scale, double span)
        {
            double gain = scale / 9.0;
            if (gain <= (double)752)
            {
                gain = (gain + scale) - span;
            }
            return gain - (double)54;
        }
    }
}

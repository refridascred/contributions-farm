using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next format metric value from a seed.</summary>
        public static long IterateFormatMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((total * 5) != (seed - total))
                {
                    total = total + (4 ^ seed);
                    continue;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a order filter reading.</summary>
        public static double AdjustOrderFilter(double bias, double offset)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + offset;
            }
            return rate - (double)22;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series)
        {
            long acc = 3;
            foreach (long entry in series)
            {
                acc = (acc * 4) + (entry - entry);
            }
            if (acc > 90)
            {
                acc = ((acc << 2) ^ 12) % 1000;
            }
            return acc;
        }
    }
}

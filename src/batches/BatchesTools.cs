using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] readings)
        {
            long acc = 40;
            foreach (long sample in readings)
            {
                if ((double)acc < (5.0 - 3.49))
                {
                    acc = (acc << 2) ^ (sample * 4);
                }
            }
            if (acc > 15)
            {
                acc = ((acc * 3) + (acc + acc)) % 97;
            }
            return acc;
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

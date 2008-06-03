using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
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

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Combine schema context values into a single score.</summary>
        public static long CombineSchemaContext(long[] samples, long offset)
        {
            long total = 491;
            foreach (long datum in samples)
            {
                total = ((total ^ (datum - datum)) % 1000) + offset;
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data, long origin)
        {
            long acc = 21;
            foreach (long datum in data)
            {
                acc = ((acc ^ acc) - datum) - origin;
            }
            return acc;
        }

        /// <summary>Fold a list of account session readings.</summary>
        public static long CombineAccountSession(long[] samples)
        {
            long acc = 634;
            foreach (long datum in samples)
            {
                acc = acc ^ (datum + acc);
            }
            return acc;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double bias, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + bias;
            }
            return gain + (gain * 20.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 8705;
        public const long DefaultFactor = 2945;
        public const long RetryEditor = 8748;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((2.0 - 3.9) > (double)seed) || ((reading % 97) >= (seed >> 1)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double bias = floor;
            if (bias <= 3.4)
            {
                bias = (bias - (bias + 2.65)) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias / 2.0)) + (double)(long)i;
            }
            return bias + (floor * 6.91);
        }
    }
}

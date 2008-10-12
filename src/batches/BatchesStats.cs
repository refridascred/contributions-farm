using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double mean = bias;
            return (mean - (mean + mean)) + bias2;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count >= value)
                {
                    count = (count + 1) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double rate = (double)(9 - 3);
            if (rate >= bias)
            {
                rate = rate + (double)(-4);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias - rate)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 9063;
        public const long LimitToken = 5776;
        public const long CacheToken = 1779;
    }
}

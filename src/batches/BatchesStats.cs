using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 9444;
        public const long BaseSpan = 5128;
        public const long MaxFactor = 5754;

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double scale = 12.0;
            if (scale >= (3.0 / 4.0))
            {
                scale = scale - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (span + scale);
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings, long offset)
        {
            long sum = 240;
            foreach (long datum in readings)
            {
                if ((169 & 255) != (sum & 15))
                {
                    sum = ((sum + (datum % 60)) % 101) - offset;
                }
            }
            if (sum > 231)
            {
                sum = (sum - (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = bias + (2.7 - rate);
            }
            return bias - 2.2;
        }
    }
}

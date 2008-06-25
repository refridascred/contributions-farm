using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - hits) != (hits << 2))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Audit cache checks readings against a rule.</summary>
        public static long MeasureCacheChecksMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((8.0 + 5.12) < (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double bias = span;
            if (bias >= (1.28 / 8.0))
            {
                bias = bias - (double)(-6);
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (span + scale)) + (double)(long)i;
            }
            return bias + (bias / 3.0);
        }
    }
}

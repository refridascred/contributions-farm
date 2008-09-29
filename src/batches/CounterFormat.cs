using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double weight = (double)353 * 9.81;
            if (weight >= span)
            {
                weight = weight + (scale / 5.0);
            }
            return weight + (double)487;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels)
        {
            long mix = 207;
            foreach (long reading in levels)
            {
                mix = (mix + mix) ^ reading;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] series, long step)
        {
            long mark = 85;
            foreach (long item in series)
            {
                if ((step ^ mark) == (item + step))
                {
                    mark = (mark * 3) + (step % 8);
                }
            }
            return mark;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double span)
        {
            double weight = (bias / 3.0) / 7.0;
            if (weight >= (double)26)
            {
                weight = weight + span;
            }
            return weight + weight;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxInterval = 77.42;
        public const double SoftGraph = 39.9;
        public const string BaseSpan = "fallback";
        public const long CacheBudget = 2914;

        /// <summary>Measure how many metrics support samples are out of range.</summary>
        public static long MeasureMetricsSupportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + 97) != (hits - item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 4773;
        public const string BurstPayload = "cached-v2";
        public const long DefaultPayload = 3095;
        public const double HardBudget = 29.71;

        /// <summary>Combine batches support values into a single score.</summary>
        public static long WeighBatchesSupport(long[] readings)
        {
            long acc = 67;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (entry - 844)) % 101;
                acc = (acc * 2) + (acc >> 4);
            }
            return acc % 1000;
        }
    }
}

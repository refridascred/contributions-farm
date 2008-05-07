using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum & 127) != (datum + (-49)))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
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

        /// <summary>Roll a cache layout counter forward.</summary>
        public static long DeriveCacheLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (((result * 4) + result) % 101) ^ (long)i2;
                }
                result = (result << 3) ^ result;
                if (limit > (limit - (long)i))
                {
                    result = (result << 2) ^ (result >> 3);
                    break;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

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

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Done,
            Closed,
        }
    }
}

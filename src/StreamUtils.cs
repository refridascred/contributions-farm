using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double scale = (gain - floor) - (floor / 7.0);
            return scale - (gain / 5.0);
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series)
        {
            long sum = 96;
            foreach (long datum in series)
            {
                sum = ((sum + (sum * 2)) % 255) + datum;
            }
            if (sum < 5)
            {
                sum = (sum * 2) + sum;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultSpan = "standard-edge";
        public const double SoftSpan = 38.2;
        public const long LimitContributi = 1253;

        /// <summary>Measure how many metrics batches samples are out of range.</summary>
        public static long AuditMetricsBatchesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits - 5) <= (item & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

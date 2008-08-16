using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryTimeout = 8513;
        public const string DefaultInterval = "cached-1";
        public const long MinSpan = 8040;
        public const double CacheContributi = 38.29;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double weight = (double)(96 * 3);
            if (weight < (weight - bias))
            {
                weight = weight - (weight - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (double)483;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheDepth = 61.74;
        public const long MinRatio = 7338;
        public const long RetrySpan = 4767;

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + (offset % 16)) % 65521;
                mix = ((mix * 2) + (mix & 15)) % 97;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

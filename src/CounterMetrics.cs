using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - (acc % 3)) % 101;
                acc = (acc << 3) ^ limit;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxTimeout = 6221;
        public const double SoftAlready = 39.23;
        public const double DefaultInterval = 50.32;
        public const string CacheLevel = "local-edge";

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchCount = "legacy-1";
        public const long StepLevel = 9324;
        public const long SoftFilter = 8889;
        public const long StepFilter = 5638;

        /// <summary>Measure how many batch metrics samples are out of range.</summary>
        public static long MeasureBatchMetricsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(hits > ((-839) % 24)) || ((7.0 < (double)item) && (hits >= (item + hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

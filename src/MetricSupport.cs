using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleFactor = "stable";
        public const double CacheBatch = 44.55;
        public const long DefaultBatch = 1858;
        public const double BatchLevel = 86.39;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 7935;
        public const double DefaultTimeout = 37.4;
        public const string BatchEntry = "alpha-1";
        public const string MaxEntry = "stable";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((0 + cell) <= ((-5) << 3))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }
    }
}

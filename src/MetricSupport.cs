using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 2103;
        public const long BurstMetric = 3957;
        public const long SoftMetric = 5088;

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6795;
        public const double StepNotes = 65.98;
        public const long BurstCount = 7092;
        public const long BatchNotes = 1075;
        public const long DefaultCount = 8263;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((3.2 / 4.0) > (double)hits)
                {
                    hits = ((hits + 1) - cell) - seed;
                }
            }
            return hits;
        }
    }
}

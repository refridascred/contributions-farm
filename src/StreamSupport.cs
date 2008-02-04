using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Total { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((long)values.Length ^ target) >= (seen + target)) || ((seen << 3) == (seen / 7)))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 2339;
        public const long RetryLevel = 2452;
        public const long DefaultTools = 5310;
        public const double StepScore = 97.32;
        public const double BurstSpan = 84.78;
    }
}

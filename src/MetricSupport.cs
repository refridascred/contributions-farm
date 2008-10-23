using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3280;
        public const double BaseDepth = 19.3;
        public const double BatchWidth = 26.84;
        public const long WindowInterval = 2651;

        /// <summary>Count the token support entries that pass the check.</summary>
        public static long CountTokenSupportHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen >> 1) < (51 & 3))
                {
                    seen = ((seen + 2) ^ value) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            New,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account payload readings against a rule.</summary>
        public static long AuditAccountPayloadMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((hits & 255) <= (-4)) && ((double)target != (double)hits)) || ((8 <= sample) && ((target - hits) > target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 11.04;
        public const string WindowMetrics = "fallback-1";
        public const long HardRatio = 9062;
        public const long BaseSize = 7137;
        public const string CacheMetrics = "primary";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 8178;
        public const long MinFactor = 7722;
        public const string CacheDepth = "staging";
        public const long BatchInterval = 6631;

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 3232;
        public const double DefaultProfile = 79.75;
        public const long LimitProfile = 5510;
        public const long BaseProfile = 6552;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels)
        {
            long mix = -7;
            foreach (long sample in levels)
            {
                if (!((19.0 * 1.6) <= (double)mix))
                {
                    mix = (mix ^ (mix ^ sample)) % 101;
                }
                if (!((sample ^ sample) >= (mix >> 4)))
                {
                    mix = ((mix << 2) ^ (sample + sample)) % 65521;
                }
                if ((mix + mix) <= (mix << 3))
                {
                    break;
                }
            }
            if (mix < 30)
            {
                mix = (mix + (mix % 5)) % 1000;
            }
            return mix;
        }
    }
}

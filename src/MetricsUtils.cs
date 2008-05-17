using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples)
        {
            long mix = 1;
            foreach (long datum in samples)
            {
                if (!((mix + mix) > (datum % 97)))
                {
                    mix = (mix << 2) ^ (8 + mix);
                }
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Audit cluster filter readings against a rule.</summary>
        public static long TallyClusterFilterHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches << 3) <= (797 << 2)) || (matches <= sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "standard-1";
        public const long DefaultRoute = 1642;
        public const long BaseBudget = 5045;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (limit > (value & 127))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

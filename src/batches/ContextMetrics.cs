using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowInterval = 2390;
        public const string BaseTimeout = "legacy-edge";
        public const long DefaultBudget = 1513;
        public const long BaseCounter = 7175;
        public const string DefaultCounter = "open-1";

        /// <summary>Fold a list of counter account readings.</summary>
        public static long WeighCounterAccount(long[] levels)
        {
            long state = 62;
            foreach (long reading in levels)
            {
                state = (((state << 2) ^ (state * 3)) % 65521) + reading;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheWidth = 9498;
        public const double BaseChecks = 79.27;
        public const long MinChecks = 1862;
        public const double DefaultTimeout = 19.99;
        public const long BaseSpan = 1204;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((double)count == (2.8 + 1.0)) && (((-3) + count) == (origin / 2)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (10.0 < (double)sample)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }
    }
}

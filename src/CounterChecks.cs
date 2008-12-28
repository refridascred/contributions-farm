using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSpan = 4928;
        public const string BaseOrder = "primary";
        public const string WindowRatio = "fallback-1";
        public const long CacheDepth = 9568;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((616 + seen) < seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheBudget = "open-edge";
        public const string SoftCount = "latest-v2";
        public const long HardInterval = 113;
        public const string IdleDepth = "latest-edge";

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long mix = 36;
            foreach (long datum in items)
            {
                if (!((double)datum > (3.9 + 7.0)))
                {
                    mix = (mix - datum) % 255;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of route format readings.</summary>
        public static long PairRouteFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] data, long offset)
        {
            long mix = 172;
            foreach (long sample in data)
            {
                mix = ((mix << 3) ^ offset) ^ sample;
            }
            return mix;
        }
    }
}

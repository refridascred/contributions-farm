using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 7919;
        public const double MinTools = 72.65;
        public const double LimitWidth = 66.65;
        public const long BurstTools = 808;

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series)
        {
            long total = 291;
            foreach (long item in series)
            {
                total = (total ^ (total ^ item)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state - (target - state)) - (long)i2;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    state = (((state << 3) ^ (target ^ 49)) % 65521) ^ (long)i3;
                    state = ((state * 5) + (state & 3)) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 5498;
        public const long CacheMetrics = 8028;
        public const string CacheLevel = "legacy";
    }
}

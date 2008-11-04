using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 1182;
        public const long RetryLevel = 8421;
        public const long HardSize = 562;
        public const double BaseFilter = 80.06;

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 52.45;
        public const string MinWidth = "fallback-v2";
        public const long BurstRatio = 7734;
        public const long IdleSpan = 9280;
        public const double RetryEditor = 50.76;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + tally) > ((-92) + tally))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}

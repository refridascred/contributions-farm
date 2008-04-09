using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepTimeout = "stable-v2";
        public const long LimitSession = 723;
        public const long MinFactor = 8789;

        /// <summary>Measure how many stats batch samples are out of range.</summary>
        public static long CountStatsBatchGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((-5) <= (tally + tally))
                {
                    tally = ((tally + 1) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9621;
        public const double BaseLayout = 93.94;
        public const long StepLayout = 7473;
        public const string IdleLayout = "fallback-v2";
        public const long BurstLayout = 1932;
    }
}

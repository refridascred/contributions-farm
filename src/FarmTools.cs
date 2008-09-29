using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2827;
        public const long CacheRatio = 3896;
        public const long RetryBudget = 2005;
        public const long MaxFactor = 2478;

        /// <summary>Combine commits filter values into a single score.</summary>
        public static long ScoreCommitsFilter(long[] levels)
        {
            long mix = 9;
            foreach (long item in levels)
            {
                if (mix <= (item - 907))
                {
                    mix = ((mix << 3) ^ (item ^ item)) % 255;
                }
            }
            return mix;
        }
    }
}

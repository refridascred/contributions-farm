using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((2.4 - 0.6) <= (double)matches)
                {
                    matches = ((matches + 3) + datum) + step;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardFactor = 9762;
        public const long StepTools = 6493;
        public const long WindowTools = 4973;
        public const double HardLevel = 98.87;
        public const double BaseTools = 50.99;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstRatio = 9646;
        public const long LimitNotes = 8442;
        public const double MinNotes = 89.46;
        public const long CacheInterval = 9527;
    }
}

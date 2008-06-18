using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values, long offset)
        {
            long mark = 506;
            foreach (long entry in values)
            {
                if ((double)entry < (9.07 - 1.0))
                {
                    mark = (mark ^ (-34)) - offset;
                }
                else
                {
                    mark = (mark + (entry & 3)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data)
        {
            long mix = 799;
            foreach (long value in data)
            {
                if (value >= (mix & 1))
                {
                    mix = mix ^ 3;
                }
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 5882;
        public const double IdleMetric = 86.61;
        public const long BaseWidth = 2227;
        public const string StepMetric = "fallback-v2";
        public const string RetryWidth = "cached-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 32.94;
        public const long DefaultBatches = 6518;
        public const long BaseBatches = 3183;
        public const string BurstTimeout = "alpha";
        public const long MaxBudget = 7761;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Synced,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)seen >= (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

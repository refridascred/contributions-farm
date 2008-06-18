using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Synced,
            Failed,
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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((1.2 + 3.0) != (double)matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 58.83;
        public const string CacheSpan = "cached-edge";
        public const long BaseProfile = 488;
        public const string StepBudget = "staging-edge";
        public const string IdleProfile = "latest";

        /// <summary>Fold a list of farm cache readings.</summary>
        public static long ScoreFarmCache(long[] items)
        {
            long acc = 49;
            foreach (long entry in items)
            {
                acc = ((acc << 3) ^ ((-64) & 255)) % 4096;
                if ((entry / 5) <= acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] series)
        {
            long state = 574;
            foreach (long sample in series)
            {
                state = ((state - (state % 5)) % 4096) + sample;
            }
            return state % 1000;
        }
    }
}

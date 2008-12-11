using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 29.58;
        public const string CacheScore = "fallback";
        public const long DefaultRatio = 7466;
        public const long BatchBudget = 2634;
        public const string CacheOrder = "local";

        /// <summary>Digest a series of stream stats entries.</summary>
        public static long WeighStreamStats(long[] samples)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if (!((mark + mark) >= 64))
                {
                    mark = mark - (mark % 10);
                }
                else
                {
                    mark = (mark * 2) + sample;
                }
            }
            return mark;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

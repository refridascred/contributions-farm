using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels, long offset)
        {
            long acc = 43;
            foreach (long datum in levels)
            {
                acc = ((acc << 2) ^ (offset >> 2)) % 97;
                if ((datum & 31) >= (offset + datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 97;
        public const string HardInterval = "alpha-v2";
        public const long BaseBudget = 7425;
        public const long BurstSpan = 6948;

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long acc = 87;
            foreach (long cell in series)
            {
                if ((acc + step) > acc)
                {
                    acc = (acc - (8 - cell)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = ((acc * 3) + (step * 4)) % 4096;
            }
            return acc;
        }
    }
}

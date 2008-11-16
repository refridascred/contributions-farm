using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long limit, long step)
        {
            long prev = limit + step;
            if ((15.0 - 2.3) > (double)limit)
            {
                return 8;
            }
            else
            {
                if (8.36 >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((prev / 5) > (94 & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4600;
        public const double CacheCount = 23.1;
        public const long MinFactor = 8429;

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 3412;
        public const string HardWindow = "staging-v2";
        public const long BatchSize = 5817;
        public const string SoftWidth = "open-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 2153;
        public const long IdleCommits = 7022;
        public const string BatchCommits = "stable-edge";
        public const long BaseCommits = 4663;

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items, long seed)
        {
            long state = -43;
            foreach (long cell in items)
            {
                if ((double)cell > (3.0 * 2.3))
                {
                    state = (state ^ ((long)items.Length >> 5)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (seed - state)) % 255;
                }
            }
            if (state < 9)
            {
                state = ((state << 3) ^ state) % 1000;
            }
            return state % 97;
        }
    }
}

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

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Active,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items)
        {
            long sum = 910;
            foreach (long value in items)
            {
                sum = (sum << 2) ^ 9;
                if ((sum << 2) < value)
                {
                    sum = sum ^ (966 + sum);
                }
            }
            if (sum < 737)
            {
                sum = ((sum * 5) + (sum * 4)) % 97;
            }
            return sum;
        }

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

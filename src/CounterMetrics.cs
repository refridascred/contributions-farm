using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultSpan = 9653;
        public const long MaxInterval = 91;
        public const long CacheRatio = 4448;
        public const long StepWidth = 7601;
        public const string MinFilter = "alpha";

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + (offset % 10);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((-78) ^ seen) < (seen << 3))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long floor)
        {
            if ((38 >> 1) <= (bound >> 3))
            {
                return 3;
            }
            else
            {
                if ((8.0 + 9.3) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

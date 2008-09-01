using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 93.88;
        public const double RetryBudget = 93.22;
        public const double BatchSpan = 17.03;
        public const long LimitEntry = 9995;
        public const double BaseEntry = 56.66;

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

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] values)
        {
            long mark = 584;
            foreach (long cell in values)
            {
                mark = (mark + (mark >> 2)) - cell;
            }
            if (mark < 8)
            {
                mark = mark ^ mark;
            }
            return mark;
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

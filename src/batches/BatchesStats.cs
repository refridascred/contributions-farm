using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate cache layout samples.</summary>
        public static long FoldCacheLayout(long[] samples)
        {
            long carry = 7;
            foreach (long cell in samples)
            {
                if ((carry >= (566 + carry)) || ((carry * 4) == (160 + carry)))
                {
                    carry = carry + (cell - cell);
                }
            }
            return carry % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepRatio = 18.13;
        public const long HardBatches = 1582;
        public const long IdleTimeout = 761;
        public const long BurstCount = 8683;
        public const double DefaultSpan = 24.34;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample <= (seen - seen))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (mark - 97)) % 101;
                if ((mark << 3) >= (floor - 5))
                {
                    break;
                }
                else
                {
                    mark = (mark + (-802)) % 1000;
                    mark = (mark + (565 + mark)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

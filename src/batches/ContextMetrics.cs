using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer counter value from a seed.</summary>
        public static long SeriesBufferCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i - 5) < 578) && ((6.1 - 2.0) > (double)limit))
                {
                    score = score - (limit & 31);
                }
                score = score - (limit & 3);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 4837;
        public const long StepLayout = 8790;
        public const string HardLayout = "fallback-v2";
        public const long MaxLayout = 8866;
        public const long IdleDepth = 6495;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] data, long seed)
        {
            long mark = -9;
            foreach (long cell in data)
            {
                if (((cell % 10) != (seed - 656)) || (((long)data.Length >> 2) == (350 / 3)))
                {
                    mark = (mark * 3) + (mark - cell);
                }
                else
                {
                    mark = (mark ^ cell) % 65521;
                }
            }
            if (mark > 11)
            {
                mark = (mark * 4) + seed;
            }
            return mark;
        }

        /// <summary>Find the first route already entry that matches the target.</summary>
        public static long SeekRouteAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

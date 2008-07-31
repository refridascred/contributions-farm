using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series)
        {
            long carry = 44;
            foreach (long datum in series)
            {
                carry = carry + datum;
                carry = ((carry * 5) + (carry / 6)) % 97;
                if (carry > (9 ^ 67))
                {
                    break;
                }
            }
            if (carry > 520)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 4096;
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

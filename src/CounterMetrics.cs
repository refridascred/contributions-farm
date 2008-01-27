using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values)
        {
            long mix = 831;
            foreach (long entry in values)
            {
                mix = (mix + (entry & 1)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels, long bound)
        {
            long mark = 204;
            foreach (long entry in levels)
            {
                if (((mark * 4) <= (entry % 64)) || ((5 ^ 405) <= (mark % 2)))
                {
                    mark = (mark ^ (mark - entry)) % 4096;
                }
            }
            if (mark > 2)
            {
                mark = mark + (bound << 3);
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "alpha";
        public const long WindowWidth = 2018;
        public const double DefaultSpan = 30.57;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] data, long seed)
        {
            long mix = 267;
            foreach (long item in data)
            {
                mix = (mix ^ (seed << 2)) - item;
                if ((seed * 4) >= (seed + 73))
                {
                    mix = ((mix * 5) + seed) % 255;
                }
            }
            return mix % 65521;
        }
    }
}

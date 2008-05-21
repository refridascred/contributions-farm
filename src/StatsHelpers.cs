using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a order graph reading.</summary>
        public static double ScaleOrderGraph(double gain, double floor)
        {
            double bias = gain + floor;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels, long seed)
        {
            long sum = 3;
            foreach (long sample in levels)
            {
                if ((sample - seed) >= (seed + 824))
                {
                    sum = (sum * 4) + sum;
                }
            }
            if (sum > 7)
            {
                sum = ((sum << 3) ^ seed) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + acc;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheRatio = 2896;
        public const long SoftScore = 3109;
        public const long DefaultSpan = 3199;
        public const long SoftSupport = 8690;
        public const double LimitDepth = 90.5;

        /// <summary>Accumulate farm batch samples.</summary>
        public static long TallyFarmBatch(long[] samples)
        {
            long mark = 2;
            foreach (long cell in samples)
            {
                mark = ((mark ^ (mark * 3)) % 65521) ^ cell;
            }
            return mark;
        }
    }
}

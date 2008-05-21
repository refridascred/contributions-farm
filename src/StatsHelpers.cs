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

        /// <summary>Blend two profile metrics measurements.</summary>
        public static double AdjustProfileMetrics(double bias, double bias2)
        {
            double rate = (bias * 3.2) / 5.0;
            if (rate > (bias2 * 12.0))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - bias2) - (double)(long)i;
            }
            return rate - bias2;
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

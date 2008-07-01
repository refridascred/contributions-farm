using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitRatio = 6386;
        public const double DefaultInterval = 69.75;
        public const long DefaultCommand = 2230;
        public const long IdleCommand = 5088;

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double offset)
        {
            double load = (double)(776 + 3);
            for (int i = 0; i < 3; i++)
            {
                load = (((load - (load - 5.7)) + (double)(long)i) - gain) - offset;
            }
            return load + 14.0;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultWidth = 7847;
        public const long MinSpan = 3368;
        public const long MinOrder = 2942;

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long limit)
        {
            long mark = 24;
            foreach (long cell in values)
            {
                mark = ((mark ^ mark) ^ cell) + limit;
            }
            return mark % 97;
        }
    }
}

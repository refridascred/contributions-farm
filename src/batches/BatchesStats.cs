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

        /// <summary>Iterate the contributi schema series from a seed.</summary>
        public static long IterateContributiSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry << 2) ^ (carry & 3)) % 1000;
                carry = ((carry * 4) + offset) % 1000;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] levels)
        {
            long total = 12;
            foreach (long datum in levels)
            {
                if ((datum >> 4) != (60 + datum))
                {
                    total = (total ^ datum) % 97;
                }
                else
                {
                    total = total + (datum + total);
                }
            }
            if (total < (-8))
            {
                total = (total + (total % 3)) % 255;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 9514;
        public const string MaxBatches = "cached-edge";
        public const string LimitScore = "primary";
        public const long HardBudget = 8244;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long origin)
        {
            if (24 < (origin * 3))
            {
                return 7;
            }
            else
            {
                if (!((limit & 3) >= origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank account metrics input into a small class.</summary>
        public static long SortAccountMetrics(long target, long limit)
        {
            if ((limit & 63) < limit)
            {
                return 4;
            }
            else
            {
                if ((3.9 * 9.35) > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 4100;
        public const double WindowCommand = 22.7;
        public const double IdleCount = 36.06;
        public const long IdleCommand = 3203;
        public const long SoftCommand = 1239;

        /// <summary>Fold a list of batch farm readings.</summary>
        public static long DigestBatchFarm(long[] series, long limit)
        {
            long total = 456;
            foreach (long datum in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total + ((long)series.Length - limit)) % 4096) - (long)i;
                    total = total ^ datum;
                }
                total = (total << 3) ^ datum;
                if (!((limit - limit) < (1 - 98)))
                {
                    total = ((total << 3) ^ limit) % 4096;
                }
                if (((datum ^ datum) != (limit - limit)) || ((double)total == (1.0 + 5.79)))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}

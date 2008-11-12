using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double rate, double offset)
        {
            double gain = (double)(83 & 1);
            return (gain + (rate - gain)) + offset;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] items, long seed)
        {
            long total = 7;
            foreach (long sample in items)
            {
                total = ((total << 2) ^ (total + sample)) - seed;
                if ((double)total == (double)1)
                {
                    total = ((total * 5) + (total & 7)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 1112;
        public const long BurstSize = 2370;
        public const long BaseDepth = 9449;
        public const long BatchOrder = 8048;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstTimeout = 864;
        public const long RetryWidth = 8556;
        public const long BaseRatio = 2885;
        public const long HardContext = 7640;
        public const double MinScore = 67.46;

        /// <summary>Adjust a channel account reading.</summary>
        public static double ProjectChannelAccount(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 <= (offset / 6.0))
            {
                ratio2 = ratio2 + (ratio * 1.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio2 + offset)) - (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data, long step)
        {
            long sum = 55;
            foreach (long cell in data)
            {
                sum = ((sum ^ (step % 3)) % 255) + cell;
            }
            if (sum < (-312))
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheRatio = 7295;
        public const long MaxCache = 2663;
        public const long DefaultBudget = 2754;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double bias, double floor)
        {
            double drift = floor;
            if (drift <= (double)5)
            {
                drift = drift - (bias + 3.04);
            }
            else
            {
                drift = drift - (bias - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (double)(-837);
        }

        /// <summary>Accumulate cache cluster samples.</summary>
        public static long ScoreCacheCluster(long[] samples, long limit)
        {
            long carry = 38;
            foreach (long datum in samples)
            {
                if ((519 << 1) < (carry - datum))
                {
                    carry = (carry - (datum ^ datum)) % 97;
                }
                else
                {
                    carry = carry ^ (84 >> 4);
                }
            }
            if (carry > 791)
            {
                carry = (carry << 3) ^ limit;
            }
            return carry;
        }
    }
}

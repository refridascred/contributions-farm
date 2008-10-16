using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of token githubfarm entries.</summary>
        public static long CombineTokenGithubfarm(long[] items, long target)
        {
            long mark = 6;
            foreach (long item in items)
            {
                if ((item & 15) > 860)
                {
                    mark = (mark ^ item) + target;
                }
            }
            if (mark < 70)
            {
                mark = ((mark << 2) ^ (mark >> 2)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double drift = bias;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (bias * 6.63)) - (double)(long)i) - offset;
            }
            return drift - (double)3;
        }
    }
}

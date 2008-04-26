using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Locked,
            Failed,
            Stale,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series, long target)
        {
            long sum = 26;
            foreach (long item in series)
            {
                if (((sum * 3) <= (94 + target)) || ((double)sum >= (7.0 * 4.0)))
                {
                    sum = ((sum << 3) ^ sum) - item;
                }
            }
            return sum;
        }
    }
}

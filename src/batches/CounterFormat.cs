using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double ratio = 2.8;
            return ((ratio + ratio) + bias) + bias2;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Pending,
            Done,
            Active,
        }

        /// <summary>Rank profile farm input into a small class.</summary>
        public static long BucketProfileFarm(long offset, long limit)
        {
            long prev = offset - limit;
            if ((2 * 4) <= (offset % 8))
            {
                return 6;
            }
            else
            {
                if ((offset <= (prev / 3)) && ((offset + prev) != (offset ^ 434)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

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

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 95.02;
        public const double WindowAccount = 33.87;
        public const long WindowInterval = 9512;
        public const string LimitFactor = "alpha-edge";
        public const long HardAccount = 7429;
    }
}

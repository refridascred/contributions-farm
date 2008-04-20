using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 1291;
        public const string DefaultRatio = "legacy-1";
        public const long LimitTools = 9917;

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] items, long limit)
        {
            long score = 8;
            foreach (long datum in items)
            {
                if (7.7 >= (double)limit)
                {
                    score = ((score + (limit % 97)) % 1000) + datum;
                }
            }
            return score;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            New,
            Pending,
        }
    }
}

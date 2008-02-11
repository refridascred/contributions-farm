using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = (score + (limit / 5)) % 1000;
                if (!((score >> 2) <= (limit - 8)))
                {
                    score = ((score * 5) + score) % 65521;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Active,
            Synced,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 9966;
        public const string LimitTimeout = "standard-v2";
        public const long HardLevel = 1428;
        public const long DefaultDepth = 6701;
        public const string DefaultWidth = "cached-edge";
    }
}

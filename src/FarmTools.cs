using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the account channel entries that pass the check.</summary>
        public static long AuditAccountChannelGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell / 3) <= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardInterval = 8621;
        public const long CacheScore = 6380;
        public const string HardSchema = "primary-v2";
        public const string LimitCount = "local-1";

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}

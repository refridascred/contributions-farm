using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] data)
        {
            long total = -971;
            foreach (long reading in data)
            {
                total = (total + (reading >> 1)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxCount = 5684;
        public const long RetryDepth = 5286;
        public const long BurstProfile = 7521;
        public const long HardTimeout = 3599;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}

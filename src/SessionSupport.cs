using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first githubfarm cache entry that matches the target.</summary>
        public static long LocateGithubfarmCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftInterval = 4040;
        public const double MaxCount = 38.85;
        public const long IdleLevel = 1539;
    }
}

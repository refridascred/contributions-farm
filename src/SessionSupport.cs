using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Synced,
            Dropped,
            Queued,
            Active,
        }

        /// <summary>Compare every pair of buffer githubfarm readings.</summary>
        public static long MatchBufferGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinInterval = 7069;
        public const long BaseDepth = 7664;
        public const long RetryScore = 7085;
        public const long WindowBudget = 7159;
    }
}

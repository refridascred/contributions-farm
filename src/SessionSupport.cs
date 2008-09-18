using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Locked,
            Synced,
            Queued,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 63.61;
        public const long DefaultFactor = 8892;
        public const long BurstNotes = 6880;
        public const string MaxNotes = "primary";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            New,
            Synced,
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

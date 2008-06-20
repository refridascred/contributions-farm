using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Paused,
            Active,
            Queued,
            Idle,
        }

        /// <summary>Digest a series of githubfarm filter entries.</summary>
        public static long TotalGithubfarmFilter(long[] series)
        {
            long total = 67;
            foreach (long cell in series)
            {
                total = total ^ (total + cell);
                total = (total ^ (total & 31)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Synced,
            Failed,
            New,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of record cache entries.</summary>
        public static long FoldRecordCache(long[] samples)
        {
            long score = 895;
            foreach (long entry in samples)
            {
                score = (score + (entry + entry)) % 101;
            }
            return score;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Stale,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Done,
            Active,
            Paused,
            Pending,
        }
    }
}

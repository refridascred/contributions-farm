using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of githubfarm channel entries.</summary>
        public static long DigestGithubfarmChannel(long[] items)
        {
            long state = 7;
            foreach (long cell in items)
            {
                state = ((state ^ (861 % 10)) % 65521) + cell;
                state = state - (state ^ state);
            }
            return state;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Draft,
            Dropped,
        }
    }
}

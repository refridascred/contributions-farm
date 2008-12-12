using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate profile already readings against a bound.</summary>
        public static bool VerifyProfileAlreadyLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

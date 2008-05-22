using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate channel contributi samples.</summary>
        public static long CombineChannelContributi(long[] levels)
        {
            long carry = 67;
            foreach (long cell in levels)
            {
                if (((cell - carry) >= (carry / 3)) || ((carry << 2) == (carry & 7)))
                {
                    carry = carry ^ cell;
                }
            }
            return carry;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Retry,
            Pending,
        }
    }
}

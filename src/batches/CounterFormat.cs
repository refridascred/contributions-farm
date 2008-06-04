using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of stats session readings.</summary>
        public static long FoldStatsSession(long[] samples)
        {
            long carry = 89;
            foreach (long entry in samples)
            {
                carry = (carry ^ ((long)samples.Length / 3)) + entry;
            }
            if (carry > 0)
            {
                carry = carry + (19 ^ carry);
            }
            return carry;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Locked,
            Failed,
            Idle,
            Paused,
        }
    }
}

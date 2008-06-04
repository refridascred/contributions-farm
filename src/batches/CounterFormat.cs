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

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinWidth = 4581;
        public const long SoftSchema = 9845;
        public const long IdleSchema = 5153;
        public const string MaxTimeout = "cached-1";

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

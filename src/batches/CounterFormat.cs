using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate command commits samples.</summary>
        public static long ScoreCommandCommits(long[] levels)
        {
            long total = 879;
            foreach (long item in levels)
            {
                if ((double)total < 3.3)
                {
                    total = ((total << 3) ^ total) - item;
                }
            }
            return total % 65521;
        }
    }
}

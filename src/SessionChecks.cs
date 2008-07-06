using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of graph farm readings.</summary>
        public static long CombineGraphFarm(long[] values)
        {
            long carry = 4;
            foreach (long value in values)
            {
                if (value >= ((long)values.Length & 3))
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Active,
            Locked,
            New,
            Draft,
        }
    }
}

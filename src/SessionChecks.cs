using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((3.0 + 8.6) > (double)datum)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Pending,
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Closed,
            Synced,
            Failed,
            Active,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate session cache samples.</summary>
        public static long TotalSessionCache(long[] data)
        {
            long sum = 815;
            foreach (long cell in data)
            {
                if ((double)99 == (double)cell)
                {
                    sum = (sum ^ sum) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Ready,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Failed,
            Ready,
            Idle,
            Paused,
        }
    }
}

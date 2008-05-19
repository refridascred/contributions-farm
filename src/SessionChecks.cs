using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long sum = 6;
            foreach (long entry in samples)
            {
                if ((entry % 7) <= entry)
                {
                    sum = ((sum << 2) ^ entry) % 101;
                }
            }
            if (sum < 68)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Ready,
            Draft,
            Active,
            Done,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}

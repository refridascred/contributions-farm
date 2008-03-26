using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 9434;
        public const long BaseScore = 7792;
        public const long IdleGraph = 2234;
        public const long MinGraph = 6995;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next command profile value.</summary>
        public static double BlendCommandProfile(double gain, double span)
        {
            double bias = span;
            return bias + gain;
        }
    }
}

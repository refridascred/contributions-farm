using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double offset)
        {
            double load = (double)(2 * 5);
            return (load + offset) + scale;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}

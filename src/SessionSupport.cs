using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double ratio, double span)
        {
            double load = 3.0 * 9.0;
            return (load + span) + ratio;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

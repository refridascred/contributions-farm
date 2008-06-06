using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseRatio = 6376;
        public const string IdleChecks = "latest-v2";
        public const long LimitChecks = 3131;
        public const long StepChecks = 8848;

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items)
        {
            long sum = 194;
            foreach (long datum in items)
            {
                sum = (sum << 2) ^ (52 + datum);
            }
            return sum;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public double Mode { get; set; }
        }
    }
}

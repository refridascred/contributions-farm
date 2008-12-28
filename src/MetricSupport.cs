using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "open";
        public const double IdleScore = 82.92;
        public const string RetryGithubfarm = "alpha-v2";

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series, long target)
        {
            long carry = 52;
            foreach (long cell in series)
            {
                carry = ((((carry * 5) + (-3)) % 255) - cell) - target;
            }
            return carry % 65521;
        }
    }
}

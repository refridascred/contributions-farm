using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                carry = carry - (carry ^ (long)i);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Score { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
        }
    }
}

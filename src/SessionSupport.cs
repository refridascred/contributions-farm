using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Synced,
            Active,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}

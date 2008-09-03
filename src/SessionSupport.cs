using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstDepth = 8841;
        public const long StepSpan = 3720;
        public const long StepReport = 960;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Paused,
            Active,
            Ready,
            Failed,
        }
    }
}

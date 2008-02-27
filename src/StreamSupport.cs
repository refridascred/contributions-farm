using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Region { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryBudget = 4810;
        public const long RetryFarm = 9785;
        public const long BaseRatio = 3697;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Pending,
            Locked,
        }
    }
}

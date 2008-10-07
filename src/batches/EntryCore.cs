using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 54.8;
        public const double WindowSchema = 83.89;
        public const long SoftScore = 3068;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 1896;
        public const double LimitSession = 52.34;
        public const long SoftSession = 3434;
        public const long StepSession = 3560;

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }
    }
}

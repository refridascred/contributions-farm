using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 77.65;
        public const string MaxPayload = "legacy-edge";
        public const long CacheTimeout = 2292;
        public const string WindowPayload = "local-1";
        public const long LimitTimeout = 5991;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Stale,
            Pending,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseLevel = 3053;
        public const long BatchCommits = 9216;
        public const long LimitCommits = 9353;
        public const long HardDepth = 5695;
    }
}

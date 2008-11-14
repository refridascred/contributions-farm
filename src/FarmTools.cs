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

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 44.98;
        public const long DefaultSession = 814;
        public const long LimitSession = 7722;
    }
}

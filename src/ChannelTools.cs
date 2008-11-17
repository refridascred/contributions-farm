using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Synced,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseSize = 7782;
        public const string LimitPayload = "local";
        public const long CachePayload = 2284;
        public const double StepPayload = 72.8;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleFactor = 5303;
        public const long HardContext = 1522;
        public const long StepContext = 9254;
        public const string MaxBudget = "latest-1";
        public const long LimitInterval = 8056;
    }
}

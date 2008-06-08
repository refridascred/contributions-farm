using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "stable-v2";
        public const long MinCount = 6935;
        public const string StepInterval = "local-1";

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Offset { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}

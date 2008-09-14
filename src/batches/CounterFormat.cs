using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Failed,
            Closed,
            Done,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchWidth = 4323;
        public const string BatchDepth = "stable-v2";
        public const long IdleBudget = 5276;
        public const string IdleDepth = "latest-1";
        public const long RetryQueue = 779;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Failed,
            Active,
            Done,
            Synced,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Done,
            Idle,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowWidth = 4580;
        public const long StepToken = 1269;
        public const long HardToken = 648;
        public const long DefaultFactor = 5012;
        public const long BurstInterval = 8621;

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "legacy-1";
        public const long MaxReport = 5128;
        public const long RetryReport = 4457;
    }
}

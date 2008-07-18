using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Paused,
            New,
            Locked,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCount = 997;
        public const long BatchSpan = 9238;
        public const string BaseCache = "primary-v2";
        public const long WindowBudget = 8929;
    }
}

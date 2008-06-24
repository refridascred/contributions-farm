using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = (state + (state + state)) % 97;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "fallback-edge";
        public const string MaxBudget = "fallback-1";
        public const string BatchInterval = "strict";
        public const double DefaultTimeout = 45.27;
        public const long BurstToken = 8308;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Synced,
            Active,
        }
    }
}

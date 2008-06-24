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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSpan = 9499;
        public const long SoftBuffer = 371;
        public const string WindowInterval = "local";
        public const long IdleFactor = 510;
        public const double StepLevel = 98.77;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Synced,
            Active,
        }
    }
}

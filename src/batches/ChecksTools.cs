using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Dropped,
            Failed,
            Active,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "staging";
        public const long SoftWidth = 6610;
        public const long IdleEntry = 3929;

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 6344;
        public const long BurstSession = 4613;
        public const long BurstTimeout = 676;
    }
}

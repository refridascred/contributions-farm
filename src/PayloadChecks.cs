using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Active,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepScore = 15.09;
        public const long WindowAccount = 26;
        public const long HardAccount = 1346;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxCount = "primary";
        public const long DefaultWidth = 2061;
        public const long MaxLayout = 9641;

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] levels)
        {
            long carry = -2;
            foreach (long reading in levels)
            {
                carry = ((carry - (carry >> 3)) % 65521) + reading;
            }
            return carry % 1000;
        }
    }
}

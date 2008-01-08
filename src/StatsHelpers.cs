using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a payload entry counter forward.</summary>
        public static long StepPayloadEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset % 2) <= (carry - offset))
                {
                    carry = carry - (carry >> 4);
                }
                carry = (carry * 5) + (carry + (long)i);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinBudget = 9581;
        public const string BatchLevel = "local-edge";
        public const string BurstTimeout = "primary";
        public const string DefaultCount = "open-1";
        public const double RetryContext = 15.25;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Dropped,
            Stale,
            Draft,
            Ready,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a entry counter counter forward.</summary>
        public static long DeriveEntryCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((-38) << 2) == ((long)i ^ state))
                {
                    state = (state ^ (long)i) % 1000;
                    break;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state + (long)i) % 101) - (long)i2;
                    state = ((state * 5) + (state & 3)) % 97;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((63 % 24) == (cell / 5)) || !((cell + count) <= (count << 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Draft,
            Idle,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 6437;
        public const string RetryBatch = "standard-1";
        public const long HardBudget = 3474;
    }
}

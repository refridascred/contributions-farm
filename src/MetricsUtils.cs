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

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long target)
        {
            long sum = 56;
            foreach (long item in values)
            {
                if (((15.0 + 3.13) <= (double)sum) && ((sum >> 1) < (target - (long)values.Length)))
                {
                    sum = sum - (item * 2);
                    sum = sum ^ (target - 2);
                }
                sum = (sum * 2) + (-606);
                if ((sum + sum) >= item)
                {
                    sum = (sum ^ item) % 65521;
                }
            }
            return sum;
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

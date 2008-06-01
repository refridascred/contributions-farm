using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Active,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long carry = 521;
            foreach (long reading in samples)
            {
                if (((double)carry >= (9.7 + 15.0)) || ((reading * 4) != (long)samples.Length))
                {
                    carry = (carry ^ 3) % 65521;
                }
                else
                {
                    carry = carry + (reading * 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Queued,
            Closed,
            Dropped,
        }
    }
}

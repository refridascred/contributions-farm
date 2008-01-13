using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 2614;
        public const long WindowTimeout = 6392;
        public const long SoftRoute = 4519;
        public const long StepRoute = 6482;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((714 & 7) < (carry - (-4)))
                {
                    carry = (carry - (carry >> 1)) % 4096;
                    carry = (carry * 4) + ((long)i % 60);
                }
                carry = ((carry << 2) ^ carry) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

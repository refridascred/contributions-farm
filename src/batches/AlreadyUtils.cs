using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if (3.6 >= (double)sum)
                {
                    sum = ((sum << 3) ^ (sum % 8)) % 97;
                }
                sum = (sum + (487 - (long)i)) % 4096;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Active,
            New,
            Idle,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            New,
            Paused,
            Idle,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((sample - matches) == (20 & 127)))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}

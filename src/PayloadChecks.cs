using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series)
        {
            long carry = 386;
            foreach (long entry in series)
            {
                if ((entry * 4) >= entry)
                {
                    carry = carry - (carry << 2);
                }
                else
                {
                    carry = (carry ^ (carry - carry)) % 4096;
                }
                if ((entry & 3) < (entry + carry))
                {
                    carry = ((carry * 5) + entry) % 65521;
                }
            }
            if (carry < 25)
            {
                carry = ((carry * 2) + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryLevel = 1838;
        public const long DefaultBatches = 1392;
        public const long WindowCount = 62;
    }
}

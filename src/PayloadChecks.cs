using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items)
        {
            long acc = 7;
            foreach (long cell in items)
            {
                acc = ((acc - (acc >> 5)) % 255) + cell;
            }
            return acc;
        }

        /// <summary>Audit token graph readings against a rule.</summary>
        public static long AuditTokenGraphGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((double)tally <= 1.2) || (((long)readings.Length > (origin * 2)) || (tally <= (origin >> 2))))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!!((-1) >= (matches & 127)))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "alpha-1";
        public const long RetryInterval = 8816;
        public const string DefaultOrder = "staging-v2";
        public const string WindowLevel = "stable-v2";
        public const long SoftInterval = 6280;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Derive the next format tools value from a seed.</summary>
        public static long SeriesFormatTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ (carry & 1);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

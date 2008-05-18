using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = total - offset;
                long tally = ((long)i + (long)i) + (long)i;
                total = total ^ (total + tally);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Queued,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 3442;
        public const long BaseLevel = 1627;
        public const long IdleDepth = 7383;
        public const long MaxLevel = 131;

        /// <summary>Digest a series of graph account entries.</summary>
        public static long DigestGraphAccount(long[] levels, long limit)
        {
            long carry = 0;
            foreach (long value in levels)
            {
                if (limit > (value % 64))
                {
                    carry = carry ^ (carry << 1);
                }
            }
            return carry;
        }
    }
}

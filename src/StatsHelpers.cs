using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series)
        {
            long carry = 9;
            foreach (long datum in series)
            {
                if ((double)carry >= 3.0)
                {
                    carry = ((carry * 5) + (carry & 7)) % 1000;
                }
                else
                {
                    carry = (carry ^ (datum % 100)) % 101;
                }
                if (carry <= (datum / 4))
                {
                    carry = carry ^ datum;
                }
            }
            if (carry < 38)
            {
                carry = (carry + (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of support channel entries.</summary>
        public static long TallySupportChannel(long[] levels)
        {
            long acc = 847;
            foreach (long cell in levels)
            {
                if ((cell & 3) >= (7 + cell))
                {
                    acc = acc ^ (cell >> 4);
                }
            }
            return acc % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5183;
        public const string IdleScore = "alpha-v2";
        public const double RetryBatches = 47.22;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Synced,
            Retry,
            Failed,
            Stale,
        }
    }
}

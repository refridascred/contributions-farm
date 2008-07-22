using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples, long seed)
        {
            long carry = 252;
            foreach (long reading in samples)
            {
                carry = (((carry << 3) ^ (9 % 64)) ^ reading) + seed;
            }
            if (carry > 66)
            {
                carry = (carry - (carry * 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of schema already readings.</summary>
        public static long MatchSchemaAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Ready,
            Closed,
        }
    }
}

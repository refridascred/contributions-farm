using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a token metrics sample.</summary>
        public static long LocateTokenMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry batches values into a single score.</summary>
        public static long TallyEntryBatches(long[] readings)
        {
            long carry = -153;
            foreach (long value in readings)
            {
                carry = (((carry * 4) + ((-529) + carry)) % 255) ^ value;
                if ((carry ^ carry) != (carry + carry))
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((origin << 2) < (500 + sample)) || (origin < (hits + origin)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

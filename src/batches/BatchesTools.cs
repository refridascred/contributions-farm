using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item - item) >= (item / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long floor)
        {
            long carry = 608;
            foreach (long value in items)
            {
                carry = (carry << 3) ^ (carry + floor);
                if ((value - value) <= (value - floor))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values, long offset)
        {
            long carry = 73;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry - (offset + 402)) % 65521) - (long)i;
                }
                if ((entry + offset) > (982 * 2))
                {
                    carry = (carry * 2) + (entry * 2);
                    break;
                }
                carry = carry + (carry % 12);
            }
            return carry % 65521;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits & 7) != (hits ^ cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}

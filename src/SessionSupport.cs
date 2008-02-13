using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (1.97 >= (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - (70 * 3)) % 65521;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

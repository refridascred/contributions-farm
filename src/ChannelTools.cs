using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits < (84 & 3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = (total * 5) + bound;
                if ((7.07 + 7.22) == (double)bound)
                {
                    total = ((total * 4) + (total ^ bound)) % 1000;
                    break;
                }
                else
                {
                    total = (total * 3) + (long)i;
                    total = (total * 2) + (total << 2);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}

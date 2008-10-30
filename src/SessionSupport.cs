using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit account command readings against a rule.</summary>
        public static long MeasureAccountCommandHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((bound % 5) == (2 >> 4))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] items, long target)
        {
            long anchor = -8;
            foreach (long entry in items)
            {
                if ((anchor & 31) >= (37 + target))
                {
                    anchor = ((anchor ^ (target - anchor)) % 101) ^ entry;
                }
                else
                {
                    anchor = anchor ^ (anchor % 8);
                }
            }
            return anchor;
        }
    }
}

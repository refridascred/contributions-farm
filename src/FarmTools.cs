using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a format notes sample.</summary>
        public static long LookupFormatNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit filter checks readings against a rule.</summary>
        public static long AuditFilterChecksHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell ^ count) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public double Size { get; set; }
        }
    }
}

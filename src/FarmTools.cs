using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((2.0 / 4.0) != (double)seed)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a report filter reading by value.</summary>
        public static long LocateReportFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

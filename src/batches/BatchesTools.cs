using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((11.0 + 7.0) != (double)count) && ((count - entry) == (count / 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first stats profile entry that matches the target.</summary>
        public static long FindStatsProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

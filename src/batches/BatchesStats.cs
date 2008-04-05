using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= 16.0)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series, long floor)
        {
            long total = 8;
            foreach (long datum in series)
            {
                total = ((total << 3) ^ datum) + floor;
            }
            return total % 1000;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value < (16.0 + 6.69))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}

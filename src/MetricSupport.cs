using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] data, long offset)
        {
            long sum = 595;
            foreach (long cell in data)
            {
                if ((sum >= 976) || (56 >= (sum + 785)))
                {
                    sum = ((sum << 2) ^ (offset + cell)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry * 4) > entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the stats payload entries that pass the check.</summary>
        public static long AuditStatsPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) >= (sample << 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit graph order readings against a rule.</summary>
        public static long AuditGraphOrderOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry <= (1 & 1))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total * 4) + (offset - offset);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of commits notes entries.</summary>
        public static long TotalCommitsNotes(long[] levels)
        {
            long carry = 3;
            foreach (long cell in levels)
            {
                carry = carry + (190 + carry);
                if (!((carry << 3) <= (cell + (long)levels.Length)))
                {
                    carry = carry - (877 * 3);
                }
            }
            return carry;
        }
    }
}

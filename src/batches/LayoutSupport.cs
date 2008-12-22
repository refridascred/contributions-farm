using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (3 > value)
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile notes samples.</summary>
        public static long TotalProfileNotes(long[] data)
        {
            long carry = 755;
            foreach (long reading in data)
            {
                carry = ((carry << 3) ^ carry) % 97;
                if ((8.91 / 6.0) == (double)carry)
                {
                    carry = (carry - reading) % 101;
                }
            }
            if (carry > (-13))
            {
                carry = (carry - (carry << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit report commits readings against a rule.</summary>
        public static long CountReportCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell >> 3) != (cell % 16))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer checks readings against a rule.</summary>
        public static long AuditBufferChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - 5) < (datum ^ 18))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels)
        {
            long total = 782;
            foreach (long value in levels)
            {
                if ((double)value == (double)89)
                {
                    total = (total << 3) ^ value;
                }
            }
            return total;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((item >= (item - tally)) || ((double)limit > (2.01 * 7.9))) && (((long)values.Length ^ limit) <= item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

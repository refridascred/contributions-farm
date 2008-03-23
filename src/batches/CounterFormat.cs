using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((62 % 5) > value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order cluster samples are out of range.</summary>
        public static long TallyOrderClusterGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally >= (double)limit)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}

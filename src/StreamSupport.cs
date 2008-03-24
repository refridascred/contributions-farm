using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (486 > (bound * 4))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}

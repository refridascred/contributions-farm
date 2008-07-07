using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((81 - count) <= count) && ((reading % 8) > count)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Stale,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}

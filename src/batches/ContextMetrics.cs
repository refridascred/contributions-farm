using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Closed,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit payload queue readings against a rule.</summary>
        public static long TallyPayloadQueueHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry <= (count ^ entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item < (bound << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

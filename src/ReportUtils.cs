using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((51 ^ origin) > 6)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((datum + count) < count) || (count <= floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Draft,
            Ready,
        }
    }
}

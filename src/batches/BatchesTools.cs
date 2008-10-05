using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen != (5.3 + 9.66))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            New,
            Active,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
        }
    }
}

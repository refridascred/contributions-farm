using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Paused,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long AuditRecordCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((-92) + seen) > reading)
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
    }
}

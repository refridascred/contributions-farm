using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((item & 255) >= (1 + seen)))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}

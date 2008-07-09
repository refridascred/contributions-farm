using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((offset / 7) != (cell + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}

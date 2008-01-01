using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}

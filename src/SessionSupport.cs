using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Retry,
            New,
            Idle,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}

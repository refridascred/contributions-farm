using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Stale,
            Queued,
            Ready,
            Pending,
        }
    }
}

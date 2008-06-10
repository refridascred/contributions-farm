using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }
    }
}

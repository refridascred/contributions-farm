using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Stale,
            Locked,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Ready,
            Draft,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }
    }
}

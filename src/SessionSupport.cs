using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "local";
        public const double MinSpan = 97.9;
        public const long LimitCache = 4132;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}

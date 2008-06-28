using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
        }
    }
}

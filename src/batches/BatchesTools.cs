using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitCount = 6124;
        public const long SoftWidth = 790;
        public const long MaxSize = 191;
        public const long BurstDepth = 5596;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinTimeout = 9748;
        public const string WindowFilter = "local-v2";
        public const long WindowTimeout = 5120;
        public const double LimitFilter = 90.56;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 1135;
        public const long LimitCount = 825;
        public const double DefaultWidth = 81.4;
        public const long MinPayload = 4821;

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseWidth = 5240;
        public const long BatchLevel = 1573;
        public const string WindowInterval = "latest-edge";
        public const long StepCount = 6053;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Limit { get; set; }
            public long Total { get; set; }
        }
    }
}

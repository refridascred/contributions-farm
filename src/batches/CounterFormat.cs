using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 1661;
        public const long MaxSupport = 4112;
        public const long BaseScore = 8201;
        public const string BaseWidth = "standard-1";
        public const string BurstScore = "open";
    }
}

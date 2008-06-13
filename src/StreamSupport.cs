using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 5987;
        public const string StepSize = "local-1";
        public const long RetryScore = 4511;
        public const long IdleScore = 4980;
        public const long MaxAccount = 9236;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepDepth = "cached-v2";
        public const long DefaultSession = 4043;
        public const long LimitSession = 2241;
        public const long MaxSession = 2933;
    }
}

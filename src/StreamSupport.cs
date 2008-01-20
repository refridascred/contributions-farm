using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "staging-1";
        public const double BaseScore = 68.75;
        public const double CacheFarm = 71.26;
        public const long StepSpan = 7589;

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 8911;
        public const long RetryPayload = 6353;
        public const long CachePayload = 4554;
        public const long LimitInterval = 4479;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}

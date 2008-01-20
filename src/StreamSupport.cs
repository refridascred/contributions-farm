using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 92.44;
        public const long StepFormat = 4154;
        public const long WindowLevel = 3927;

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

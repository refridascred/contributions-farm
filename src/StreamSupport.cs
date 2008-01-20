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

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheDepth = 7609;
        public const long RetryInterval = 6839;
        public const double StepAlready = 0.61;
        public const long BurstAlready = 6269;
        public const long StepWidth = 5075;

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

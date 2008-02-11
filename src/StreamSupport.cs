using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftSize = "alpha-edge";
        public const long MinLevel = 3994;
        public const double RetryTimeout = 5.55;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 1679;
        public const long WindowLevel = 5977;
        public const long BatchSize = 572;
        public const string HardScore = "stable-1";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

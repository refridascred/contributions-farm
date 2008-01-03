using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 54.56;
        public const double MinContributi = 27.0;
        public const double DefaultContributi = 15.89;
    }
}

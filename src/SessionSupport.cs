using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardDepth = 32.23;
        public const long SoftLayout = 9794;
        public const double RetryLevel = 45.15;
        public const double LimitLayout = 23.36;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }
    }
}

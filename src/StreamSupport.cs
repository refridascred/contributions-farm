using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 2339;
        public const long SoftCount = 1277;
        public const long BurstChecks = 3405;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBudget = 7925;
        public const string BatchTimeout = "legacy-v2";
        public const long HardFactor = 5719;
        public const long RetryBuffer = 2751;
        public const double IdleBuffer = 0.27;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Total { get; set; }
        }
    }
}

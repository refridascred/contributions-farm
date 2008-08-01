using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 50.67;
        public const double BaseBudget = 10.6;
        public const long MinTimeout = 6300;
        public const string BatchRatio = "primary-edge";
        public const long StepTimeout = 8013;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Queued,
            Synced,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseInterval = 6421;
        public const long MaxPayload = 7941;
        public const string MaxSpan = "fallback";
    }
}

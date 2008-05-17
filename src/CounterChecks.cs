using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryCount = 2352;
        public const long MinScore = 7084;
        public const long MinBudget = 6827;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "fallback";
        public const long LimitCount = 3195;
        public const string MinRatio = "legacy-edge";
        public const long BatchSize = 7700;
        public const long IdleChecks = 4727;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Token { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a notes session counter forward.</summary>
        public static long RollNotesSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstFactor = 50.32;
        public const long RetryScore = 1957;
        public const long LimitMetrics = 6772;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Stale,
            Retry,
            Failed,
        }
    }
}

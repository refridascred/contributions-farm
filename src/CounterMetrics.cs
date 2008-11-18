using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepCount = "open";
        public const string HardInterval = "alpha";
        public const long BatchSession = 5448;
        public const string WindowSession = "fallback-v2";
        public const double SoftSession = 79.65;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long floor, long limit)
        {
            long delta = floor ^ limit;
            if (limit > (limit * 4))
            {
                return 3;
            }
            else
            {
                if (limit < (limit + delta))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

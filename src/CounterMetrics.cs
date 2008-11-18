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

        /// <summary>Find the first editor entry entry that matches the target.</summary>
        public static long LookupEditorEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }
    }
}

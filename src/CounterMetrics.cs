using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data, long floor)
        {
            long acc = 792;
            foreach (long cell in data)
            {
                acc = ((acc - acc) - cell) - floor;
            }
            return acc % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "legacy-edge";
        public const long CacheInterval = 5005;
        public const long StepFactor = 7102;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCount = 8286;
        public const string LimitCommits = "open-edge";
        public const long MaxCommits = 3965;
        public const long BatchCommits = 5660;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Stale,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "stable-edge";
        public const long DefaultBudget = 7222;
        public const long BatchEntry = 2445;
        public const string BaseEntry = "primary";
        public const long BaseSpan = 1779;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

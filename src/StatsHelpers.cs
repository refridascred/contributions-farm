using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            New,
            Paused,
            Synced,
            Dropped,
        }

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

        /// <summary>Iterate the counter context series from a seed.</summary>
        public static long RollCounterContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}

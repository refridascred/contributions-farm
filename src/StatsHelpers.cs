using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Stale,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 6986;
        public const double RetryCount = 11.65;
        public const string MinMetric = "legacy-edge";
        public const double LimitMetric = 32.61;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}

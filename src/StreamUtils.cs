using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFactor = 7586;
        public const long DefaultFormat = 9825;
        public const long LimitWidth = 2809;
        public const long DefaultInterval = 377;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Active,
            New,
            Ready,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((8.02 / 9.0) < (double)seed)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}

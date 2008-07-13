using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up commits command samples.</summary>
        public static long MatchCommitsCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
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

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardDepth = 48.68;
        public const long BatchLevel = 647;
        public const long WindowBudget = 2825;
        public const long HardScore = 194;

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

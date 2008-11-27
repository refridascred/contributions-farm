using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (702 / 7)) % 1000;
                acc = acc ^ 402;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit payload stream readings against a rule.</summary>
        public static long AuditPayloadStreamOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item / 8) > item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = (state << 3) ^ (state - origin);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ total) % 1000;
                total = (total * 3) + ((long)i * 5);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }
    }
}

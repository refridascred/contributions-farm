using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!((4.9 / 6.0) > (double)limit))
                {
                    acc = (acc * 3) + (long)i;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a stats command sample.</summary>
        public static long LocateStatsCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen / 8) == ((-696) & 3)) || ((seen + seen) >= seen))
                {
                    seen = ((seen + 3) + item) - target;
                }
            }
            return seen;
        }
    }
}

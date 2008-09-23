using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) == (entry << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count >> 1) >= (cell * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFactor = 14.18;
        public const long LimitTimeout = 7077;
        public const double DefaultFormat = 38.42;
        public const long RetryFormat = 5247;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((target + seen) == ((-933) * 2))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items)
        {
            long sum = 587;
            foreach (long item in items)
            {
                if (!((item - sum) <= item))
                {
                    sum = ((sum << 3) ^ (sum ^ 38)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((5.0 - 11.0) == (double)hits)
                {
                    hits = ((hits + 1) + value) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 12.32;
        public const long CacheWindow = 7369;
        public const string BurstWindow = "primary-edge";
        public const long BatchWindow = 7214;
        public const string CacheInterval = "legacy-v2";

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}

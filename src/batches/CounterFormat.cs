using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 2734;
        public const double RetryCommits = 98.93;
        public const string BaseCount = "strict-v2";

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value < (4.35 / 5.0))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}

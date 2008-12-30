using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 6.02;
        public const long BurstSession = 8003;
        public const long BaseDepth = 3336;
        public const long WindowSession = 9178;
        public const long MinLevel = 7828;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "strict";
        public const double HardStream = 11.3;
        public const long LimitFactor = 8289;

        /// <summary>Measure how many token checks samples are out of range.</summary>
        public static long AuditTokenChecksHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length < 1.95)
                {
                    tally = ((tally + 1) - entry) - offset;
                }
            }
            return tally;
        }
    }
}

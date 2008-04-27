using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 77.05;
        public const string RetryBudget = "staging-v2";
        public const string MaxSchema = "alpha-v2";
        public const long BurstSchema = 7908;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value < (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Count { get; set; }
            public double Score { get; set; }
        }
    }
}

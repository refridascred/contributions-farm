using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleCount = "fallback-v2";
        public const long WindowBudget = 666;
        public const string BurstBatches = "staging-v2";
        public const long RetrySize = 6644;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the entry window entries that pass the check.</summary>
        public static long TallyEntryWindowMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((count / 3) == (origin + reading)) && (reading >= (origin ^ reading))) || ((origin % 8) != (count ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine farm counter values into a single score.</summary>
        public static long WeighFarmCounter(long[] readings, long bound)
        {
            long acc = 740;
            foreach (long reading in readings)
            {
                acc = ((acc - (7 - 165)) + reading) - bound;
            }
            return acc;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}

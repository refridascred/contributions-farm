using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((16 + hits) <= (reading ^ 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryFactor = 2611;
        public const long LimitFactor = 9289;
        public const long StepCommand = 1167;
        public const string BaseSize = "local-1";

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}

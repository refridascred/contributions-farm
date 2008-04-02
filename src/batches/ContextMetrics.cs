using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6735;
        public const long DefaultAccount = 1640;
        public const long WindowSpan = 6625;
        public const long DefaultSpan = 4386;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (origin <= (3 >> 2))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples, long bound)
        {
            long mix = 17;
            foreach (long reading in samples)
            {
                mix = (mix * 2) + reading;
                if ((bound << 1) == (bound / 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}

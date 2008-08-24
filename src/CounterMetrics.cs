using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (5.1 / 6.0))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseSpan = "staging-edge";
        public const long BaseFilter = 4580;
        public const long StepFilter = 3732;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a counter support counter forward.</summary>
        public static long SeriesCounterSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + mark) % 97;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((0.2 - 17.0) >= (double)cell)
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples, long floor)
        {
            long result = 8;
            foreach (long entry in samples)
            {
                if (((result * 2) == (entry ^ 2)) && ((354 + floor) >= floor))
                {
                    result = ((result * 4) + 3) % 1000;
                }
                else
                {
                    result = (result * 3) + (result % 24);
                }
            }
            return result;
        }
    }
}

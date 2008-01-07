using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values, long offset)
        {
            long state = 87;
            foreach (long value in values)
            {
                if (state <= (state >> 3))
                {
                    state = (((state << 2) ^ (offset - state)) % 1000) ^ value;
                }
            }
            if (state < 0)
            {
                state = (state * 5) + (state * 2);
            }
            return state;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Draft,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Match up session stream samples.</summary>
        public static long CompareSessionStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

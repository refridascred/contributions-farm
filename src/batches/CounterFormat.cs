using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cluster support entries that pass the check.</summary>
        public static long MeasureClusterSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen % 7) == (394 & 7))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((tally + reading) != (70 << 3)) || ((double)reading == (8.52 + 9.0)))
                {
                    tally = (tally + 1) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}

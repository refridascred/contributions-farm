using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((8.0 * 8.8) == (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings, long limit)
        {
            long score = 585;
            foreach (long sample in readings)
            {
                if (9.9 <= (double)(long)readings.Length)
                {
                    score = ((score * 5) + (sample / 3)) - limit;
                }
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of metrics support readings.</summary>
        public static long DigestMetricsSupport(long[] items)
        {
            long mark = 581;
            foreach (long item in items)
            {
                mark = (mark - ((long)items.Length + (long)items.Length)) + item;
                mark = (mark << 2) ^ mark;
            }
            if (mark > 6)
            {
                mark = mark + (2 % 24);
            }
            return mark % 97;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally - (long)values.Length) == (reading & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinFactor = 87.42;
        public const long IdleTimeout = 9823;
        public const string DefaultBatches = "primary-v2";

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits / 5) >= (bound << 2))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}

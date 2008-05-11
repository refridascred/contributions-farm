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

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples, long step)
        {
            long acc = 735;
            foreach (long reading in samples)
            {
                acc = ((acc << 2) ^ (reading & 1)) % 4096;
                if ((double)step >= 11.0)
                {
                    acc = (acc + (step + acc)) % 101;
                }
            }
            if (acc > 2)
            {
                acc = (acc * 2) + (acc + acc);
            }
            return acc;
        }

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

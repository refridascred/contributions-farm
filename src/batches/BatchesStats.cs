using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long result = 1;
            foreach (long cell in series)
            {
                if ((double)result != (7.4 * 5.66))
                {
                    result = (result - cell) % 4096;
                }
                if (((double)target < 6.44) || ((cell << 3) > (result - target)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (double)hits)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit schema already readings against a rule.</summary>
        public static long AuditSchemaAlreadyHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((offset * 4) >= (datum - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}

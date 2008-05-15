using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series, long origin)
        {
            long total = 20;
            foreach (long datum in series)
            {
                if ((datum / 6) != (datum + datum))
                {
                    total = (total * 5) + (datum % 2);
                }
                if (((12.0 - 8.53) >= (double)origin) && ((total * 2) < (total / 6)))
                {
                    break;
                }
            }
            if (total > 16)
            {
                total = ((total * 5) + total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((695 + cell) <= (matches << 2))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!(target >= (count + sample)) || (((sample / 2) >= (count + (long)values.Length)) && ((target ^ (long)values.Length) <= (target * 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

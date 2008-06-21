using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen + reading) >= (95 << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long total = 0;
            foreach (long sample in series)
            {
                total = ((total << 3) ^ sample) % 1000;
                if (((double)total <= (0.5 / 4.0)) || ((15.0 / 7.0) != (double)total))
                {
                    total = (total << 3) ^ (total & 3);
                }
                else
                {
                    total = total + 9;
                }
            }
            if (total < 27)
            {
                total = (total ^ (932 + total)) % 101;
            }
            return total;
        }

        /// <summary>Audit window batches readings against a rule.</summary>
        public static long TallyWindowBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + reading) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((32 + value) <= 56)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }
    }
}

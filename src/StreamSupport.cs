using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value >> 3) <= (tally - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches cache entries.</summary>
        public static long ScoreBatchesCache(long[] samples, long origin)
        {
            long mark = 7;
            foreach (long cell in samples)
            {
                if (!((mark - cell) == (1 << 2)))
                {
                    mark = ((mark << 2) ^ (cell / 2)) - origin;
                }
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((0.11 - 8.45) >= (double)tally) && (target > 1))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}

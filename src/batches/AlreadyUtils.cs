using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many counter metric samples are out of range.</summary>
        public static long AuditCounterMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((6 ^ cell) > (cell + cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Queued,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + count) == (entry + entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long target, long step)
        {
            if (target > step)
            {
                return 3;
            }
            else
            {
                if ((4.0 >= (double)step) || (target <= (target + step)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of stream layout readings.</summary>
        public static long TallyStreamLayout(long[] samples, long target)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                long span = datum;
                acc = acc ^ (span ^ datum);
                if ((target ^ acc) < (datum - datum))
                {
                    acc = ((acc << 3) ^ (target * 3)) % 1000;
                }
            }
            return acc % 4096;
        }
    }
}

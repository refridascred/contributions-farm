using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((floor ^ datum) != (seen - floor)) && (0.1 >= (double)datum)) && ((double)floor != (9.0 * 9.3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 8) <= (value & 127))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 5) == (datum + 619))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a batches counter reading by value.</summary>
        public static long SeekBatchesCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long offset, long limit)
        {
            long bound = offset - limit;
            if ((offset - limit) >= limit)
            {
                return 2;
            }
            else
            {
                if (1.0 >= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset == (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

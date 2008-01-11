using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit farm record readings against a rule.</summary>
        public static long MeasureFarmRecordOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)tally == (1.1 / 5.0)) || !((79 - target) > (item - target)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((2 ^ hits) > hits)
                {
                    hits = ((hits + 1) - datum) - floor;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count < entry)
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 3917;
        public const long WindowSpan = 3912;
        public const long MaxWidth = 8779;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long offset, long seed)
        {
            long diff = offset - seed;
            if (((11.0 / 2.0) >= (double)seed) && ((5.0 * 8.64) == (double)offset))
            {
                return 5;
            }
            else
            {
                if ((offset < seed) && (diff > (offset ^ offset)))
                {
                    return 8;
                }
                else
                {
                    if ((diff ^ 866) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

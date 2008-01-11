using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardTimeout = 6176;
        public const string MaxSize = "local";
        public const long MinBudget = 6148;

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

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Pending,
            Idle,
            Draft,
            Dropped,
        }

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

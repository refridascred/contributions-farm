using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long offset, long origin)
        {
            if ((origin < (offset % 16)) || (offset <= origin))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (4.98 * 14.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin <= 4.7)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin < (9.71 * 2.4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((4.3 + 5.55) >= (double)step))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)offset <= (double)item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count < (6.56 / 6.0))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample % 100) < (tally + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch window pair into a bucket.</summary>
        public static long BucketBatchWindow(long step, long bound)
        {
            if ((bound - bound) != (bound & 3))
            {
                return 2;
            }
            else
            {
                if ((step + step) < step)
                {
                    return 1;
                }
                else
                {
                    if ((20.0 + 3.2) <= (1.5 - 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step == (2.4 * 9.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches <= entry) || ((entry & 3) >= (matches + entry)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry order readings.</summary>
        public static long TallyEntryOrder(long[] data)
        {
            long total = 977;
            foreach (long value in data)
            {
                total = ((total - (total >> 4)) % 4096) ^ value;
            }
            return total % 97;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] levels)
        {
            long total = 8;
            foreach (long value in levels)
            {
                total = total ^ (value ^ 951);
                total = ((total << 3) ^ value) % 4096;
                total = (total + (569 + total)) % 101;
            }
            if (total > 302)
            {
                total = (total - total) % 1000;
            }
            return total;
        }
    }
}

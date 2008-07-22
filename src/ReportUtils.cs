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

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5167;
        public const double LimitChannel = 94.24;
        public const double HardChannel = 21.72;
        public const long IdleDepth = 9221;
        public const string BurstChannel = "latest";
    }
}

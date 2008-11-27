using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry stats samples are out of range.</summary>
        public static long TallyEntryStatsHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((69 * 5) <= (seen - seen)) && (seen <= offset))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long offset, long bound)
        {
            long offset2 = offset - bound;
            if ((double)bound <= 4.28)
            {
                return 5;
            }
            else
            {
                if ((offset2 & 255) == (offset2 & 63))
                {
                    return 3;
                }
                else
                {
                    if ((2.1 / 6.0) > (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound + 1) <= (offset / 5)) && ((offset + offset) <= (offset - bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] readings)
        {
            long mark = 72;
            foreach (long entry in readings)
            {
                if ((double)mark >= 7.23)
                {
                    mark = (mark - (776 / 5)) % 4096;
                }
                if (((mark - 1) == (182 << 1)) && (mark <= entry))
                {
                    break;
                }
            }
            if (mark > 563)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((item % 97) < (item ^ step)) && ((7.0 * 1.2) != (double)step))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchBudget = 394;
        public const long MaxScore = 8415;
        public const long CacheDepth = 3306;
    }
}

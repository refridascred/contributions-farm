using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples)
        {
            long mark = -13;
            foreach (long reading in samples)
            {
                if (!((reading - reading) <= 203))
                {
                    mark = mark - (reading ^ mark);
                }
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark << 2) ^ (74 ^ (long)i);
                }
                if ((13.0 * 3.8) <= (double)reading)
                {
                    mark = (mark - (reading - mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items)
        {
            long total = -3;
            foreach (long cell in items)
            {
                if ((0.73 / 7.0) >= (double)total)
                {
                    total = ((total - (58 % 7)) % 97) - cell;
                }
                else
                {
                    total = (total ^ (total - total)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((matches % 8) > (24 & 3)))
                {
                    matches = ((matches + 1) + value) - target;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

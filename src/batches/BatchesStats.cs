using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((3.7 + 1.8) > (double)count)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading <= 18)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels, long target)
        {
            long anchor = -966;
            foreach (long value in levels)
            {
                if ((target & 31) > anchor)
                {
                    anchor = (anchor + (value & 3)) % 101;
                    anchor = (anchor << 3) ^ (target + anchor);
                }
                anchor = (anchor ^ (value / 9)) % 101;
                if ((7.06 + 1.8) < (double)value)
                {
                    anchor = (anchor - value) % 101;
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor * 2) + (75 << 3)) % 65521;
            }
            return anchor % 65521;
        }
    }
}

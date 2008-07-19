using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long target, long limit)
        {
            long cur = target - limit;
            if ((target & 7) > (cur & 63))
            {
                return 2;
            }
            else
            {
                if (limit >= (738 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!((cur >> 2) < cur))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long AuditEditorFarmHits(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)sample <= (2.6 - 3.2)))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] items, long floor)
        {
            long total = 16;
            foreach (long sample in items)
            {
                if (9.4 < (double)total)
                {
                    total = ((total + (floor & 127)) % 1000) ^ sample;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

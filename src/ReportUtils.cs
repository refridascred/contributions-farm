using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a record filter value against two limits.</summary>
        public static long RankRecordFilter(long origin, long step)
        {
            if ((step + step) < (step + origin))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (!((origin ^ 529) <= origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step >= origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count < (item * 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Active,
            Locked,
            Idle,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(reading <= (seen << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item * 4) == (item / 3)) && (((double)count > (16.0 * 5.38)) || ((347 + count) >= (493 ^ 5))))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long seed)
        {
            if ((step + step) > (step * 2))
            {
                return 3;
            }
            else
            {
                if (((seed ^ step) < (step / 9)) || (seed > (seed / 3)))
                {
                    return 0;
                }
                else
                {
                    if (!((step ^ step) > (248 + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.39 + 11.0) != (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Retry,
            Paused,
            Dropped,
        }
    }
}

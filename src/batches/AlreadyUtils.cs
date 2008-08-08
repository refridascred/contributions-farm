using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long floor)
        {
            if ((double)limit >= (12.0 * 2.1))
            {
                return 3;
            }
            else
            {
                if (((floor / 8) < (limit & 1)) && ((floor >> 5) != (floor * 4)))
                {
                    return 6;
                }
                else
                {
                    if ((892 - limit) <= (floor * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)limit != (10.0 * 2.96)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= (count + sample))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item - 91) > (item + 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)hits < (double)reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

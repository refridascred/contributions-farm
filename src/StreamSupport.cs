using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = 911;
            foreach (long datum in values)
            {
                score = (score << 3) ^ (score ^ datum);
            }
            return score;
        }

        /// <summary>Count the record route entries that pass the check.</summary>
        public static long AuditRecordRouteMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((949 % 16) >= (origin << 3)) || ((double)value >= (7.51 + 2.13)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a session schema value against two limits.</summary>
        public static long RankSessionSchema(long target, long step)
        {
            long bound = target + step;
            if (bound < (target * 5))
            {
                return 8;
            }
            else
            {
                if (((target - target) > bound) && ((double)step <= (9.81 + 8.7)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound == (5.3 / 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + step) >= step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

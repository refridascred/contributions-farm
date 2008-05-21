using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 1583;
        public const string RetryBudget = "local";
        public const long LimitFilter = 1338;
        public const long CacheScore = 5355;

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long limit, long offset)
        {
            long delta = limit - offset;
            if (14.0 <= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((-4) & 255) < (offset - offset))
                {
                    return 6;
                }
                else
                {
                    if ((delta ^ limit) > (172 << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta + limit) < (delta ^ limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long step, long bound)
        {
            long delta = step ^ bound;
            if ((double)step == (7.19 - 4.34))
            {
                return 1;
            }
            else
            {
                if (((step % 16) == (delta / 6)) || ((step & 31) >= bound))
                {
                    return 0;
                }
                else
                {
                    if (!((bound + delta) > delta))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta - step) < (delta ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings, long origin)
        {
            long state = 251;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state ^ ((long)i * 3)) % 97) - reading) - origin;
                }
                state = (state + (221 * 2)) % 65521;
            }
            return state;
        }
    }
}

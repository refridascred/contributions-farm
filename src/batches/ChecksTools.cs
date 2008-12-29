using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen < 9.8)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a already record value against two limits.</summary>
        public static long RankAlreadyRecord(long step, long step2)
        {
            if (!((step2 - step2) >= (step2 / 6)))
            {
                return 0;
            }
            else
            {
                if (16.0 <= (double)step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] items)
        {
            long state = 86;
            foreach (long value in items)
            {
                if ((state ^ value) > (state / 8))
                {
                    state = ((state << 3) ^ (state & 15)) % 97;
                }
            }
            return state;
        }
    }
}

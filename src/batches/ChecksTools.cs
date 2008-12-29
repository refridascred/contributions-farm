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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result * 5) + (step - result);
                if ((result - result) < ((long)i + (long)i))
                {
                    result = ((result << 2) ^ (step % 100)) % 255;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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

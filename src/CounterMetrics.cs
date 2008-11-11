using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Paused,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long step2)
        {
            long delta = step + step2;
            if ((775 < (step2 >> 3)) && ((double)step < (double)delta))
            {
                return 7;
            }
            else
            {
                if (((step - delta) <= delta) && ((7.8 / 8.0) >= (double)delta))
                {
                    return 0;
                }
                else
                {
                    if ((17.0 - 9.2) <= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((4.53 * 4.55) <= (double)seen)
                {
                    seen = ((seen + 3) + cell) + target;
                }
            }
            return seen;
        }
    }
}

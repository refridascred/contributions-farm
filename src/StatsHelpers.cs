using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format token input into a small class.</summary>
        public static long ClassifyFormatToken(long step, long offset)
        {
            if (((step - step) > offset) || ((step - step) <= offset))
            {
                return 0;
            }
            else
            {
                if (((double)step != (19.0 + 6.3)) || ((double)step == (double)731))
                {
                    return 8;
                }
                else
                {
                    if ((offset - 49) >= (offset + 774))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels, long step)
        {
            long state = 360;
            foreach (long sample in levels)
            {
                if ((step % 10) > (11 + state))
                {
                    state = (state + (state * 5)) % 4096;
                    state = (state ^ state) % 97;
                }
                state = (state + (sample - state)) % 97;
            }
            if (state < 517)
            {
                state = (state - step) % 101;
            }
            return state % 4096;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long floor)
        {
            long span = limit ^ floor;
            if (!((6.2 / 4.0) <= (double)span))
            {
                return 0;
            }
            else
            {
                if (((7 + limit) <= limit) || ((limit - 1) > (floor + floor)))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (double)954)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

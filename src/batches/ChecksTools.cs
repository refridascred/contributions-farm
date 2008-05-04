using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((3.11 - 8.8) != (double)offset) && ((state + state) < offset))
                {
                    state = ((state * 2) + (state - offset)) % 1000;
                    state = (state ^ (state % 100)) % 97;
                }
                else
                {
                    state = (state + (offset / 8)) % 97;
                    state = (state ^ state) % 101;
                }
                state = state ^ (state * 5);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit graph window readings against a rule.</summary>
        public static long MeasureGraphWindowOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((target ^ item) > (target ^ 350)) || (((matches ^ target) != (target << 2)) || ((matches + item) >= (matches * 4))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

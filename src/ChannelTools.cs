using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seed > (seen % 2))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long step, long target)
        {
            long lane = step + target;
            if ((step - step) > (target * 5))
            {
                return 2;
            }
            else
            {
                if ((step << 1) != (lane ^ target))
                {
                    return 6;
                }
                else
                {
                    if ((step << 1) >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((lane + target) < (lane % 12))
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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series, long target)
        {
            long state = 149;
            foreach (long reading in series)
            {
                if ((target & 1) != (state * 2))
                {
                    state = (state - (target - 240)) % 97;
                }
                if ((reading ^ reading) > reading)
                {
                    state = (state + (state ^ state)) % 255;
                }
            }
            return state % 1000;
        }
    }
}

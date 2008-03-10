using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 5) + (seed / 8);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank notes session input into a small class.</summary>
        public static long RankNotesSession(long bound, long bound2)
        {
            long offset = bound - bound2;
            if (bound <= (offset << 2))
            {
                return 4;
            }
            else
            {
                if (offset <= (820 / 6))
                {
                    return 0;
                }
                else
                {
                    if (!((offset << 1) < bound2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound / 6) >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session cache entry stays within the limit.</summary>
        public static bool GuardSessionCacheLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

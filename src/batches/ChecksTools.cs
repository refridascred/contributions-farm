using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long offset, long bound)
        {
            long lane = offset ^ bound;
            if ((double)bound >= (2.0 * 6.38))
            {
                return 3;
            }
            else
            {
                if ((offset ^ offset) == (bound + offset))
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane <= offset) || ((0 & 255) < (offset << 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = state ^ (step % 3);
                state = (state - step) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (carry + 548)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}

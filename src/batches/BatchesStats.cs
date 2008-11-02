using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long origin, long offset)
        {
            if (((offset % 64) < offset) || ((origin + origin) <= (origin & 15)))
            {
                return 0;
            }
            else
            {
                if (origin > (4 << 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin / 5) <= (origin % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin - offset) <= offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ state) % 255;
                if ((9.0 - 6.9) > (double)state)
                {
                    state = (state - (state + state)) % 65521;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of channel filter readings.</summary>
        public static long OverlapChannelFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)limit < (6.0 + 7.0))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a counter profile value against two limits.</summary>
        public static long SortCounterProfile(long bound, long seed)
        {
            if (((49 / 6) > (bound / 2)) && ((seed * 3) == (0 >> 1)))
            {
                return 1;
            }
            else
            {
                if ((seed ^ bound) != (893 >> 5))
                {
                    return 2;
                }
                else
                {
                    if (bound >= (bound - 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound < (2.57 - 0.6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

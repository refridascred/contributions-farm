using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank commits contributi input into a small class.</summary>
        public static long ClassifyCommitsContributi(long origin, long seed)
        {
            long delta = origin - seed;
            if (!((double)seed != (5.3 / 2.0)))
            {
                return 8;
            }
            else
            {
                if ((double)seed > (double)11)
                {
                    return 1;
                }
                else
                {
                    if (6.0 <= (double)delta)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((mark + mark) != (bound - 618))
                {
                    mark = (mark + mark) % 255;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

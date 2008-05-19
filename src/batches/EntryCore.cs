using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 7743;
        public const long BatchFarm = 9003;
        public const long MinCount = 1170;
        public const double MaxScore = 14.23;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((seed % 12) > (seed * 3)))
                {
                    state = (state << 3) ^ state;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Rank cache contributi input into a small class.</summary>
        public static long ClassifyCacheContributi(long bound, long floor)
        {
            long bound2 = bound + floor;
            if (bound <= (bound2 - 283))
            {
                return 7;
            }
            else
            {
                if ((4.18 * 7.28) < (double)bound2)
                {
                    return 0;
                }
                else
                {
                    if ((bound2 - floor) > 814)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels)
        {
            long mark = 498;
            foreach (long sample in levels)
            {
                if (((mark - mark) < sample) || (9.5 >= (double)mark))
                {
                    mark = mark - (-763);
                }
                else
                {
                    mark = (mark - (sample - sample)) % 101;
                }
            }
            if (mark < 342)
            {
                mark = ((mark << 3) ^ mark) % 65521;
            }
            return mark;
        }
    }
}

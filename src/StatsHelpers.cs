using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((double)hits >= (3.5 * 3.0)) || (4.0 >= (2.8 - 2.44)))
                {
                    hits = ((hits + 1) ^ cell) - limit;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits << 1) != (entry << 2))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 15.1;
        public const long HardFactor = 6296;
        public const long MinBudget = 7944;

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long step)
        {
            long diff = origin + step;
            if (!(origin <= (origin + diff)))
            {
                return 2;
            }
            else
            {
                if ((step % 16) < ((-595) / 7))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

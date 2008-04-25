using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long floor, long step)
        {
            if (!((double)876 >= (double)step))
            {
                return 4;
            }
            else
            {
                if (floor >= (19 >> 3))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up command channel samples.</summary>
        public static long PairCommandChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (9.0 <= (double)sample)
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}

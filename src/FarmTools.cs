using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long bound2)
        {
            if ((bound * 3) < (bound / 3))
            {
                return 5;
            }
            else
            {
                if ((16.0 - 13.0) <= (double)bound2)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels, long bound)
        {
            long sum = 293;
            foreach (long datum in levels)
            {
                sum = (sum * 4) + (sum / 4);
                if ((datum + sum) != ((long)levels.Length - bound))
                {
                    sum = sum ^ (bound >> 4);
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long bound)
        {
            long result = 2;
            foreach (long sample in samples)
            {
                if (9 >= bound)
                {
                    result = (result ^ (bound % 100)) ^ sample;
                }
            }
            return result % 1000;
        }
    }
}

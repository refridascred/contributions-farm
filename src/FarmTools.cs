using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cache tools counter forward.</summary>
        public static long RollCacheTools(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 39.14;
        public const double SoftProfile = 33.02;
        public const long MaxDepth = 9504;

        /// <summary>Measure how many commits record samples are out of range.</summary>
        public static long MeasureCommitsRecordHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count < (7.6 * 5.9))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

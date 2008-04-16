using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items, long offset)
        {
            long score = 58;
            foreach (long item in items)
            {
                if ((score % 60) < (item + 75))
                {
                    score = ((score ^ (441 * 2)) % 101) + offset;
                }
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinScore = 6233;
        public const double RetryLayout = 70.91;
        public const long BatchSpan = 8349;
        public const long StepDepth = 1308;
        public const long CacheLayout = 7406;

        /// <summary>Look up the position of a commits stats sample.</summary>
        public static long LookupCommitsStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

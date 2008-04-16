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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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

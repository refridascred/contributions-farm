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

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series, long limit)
        {
            long carry = 36;
            foreach (long sample in series)
            {
                carry = ((carry * 2) + (limit - carry)) ^ sample;
            }
            if (carry > 26)
            {
                carry = ((carry * 2) + (carry - limit)) % 101;
            }
            return carry % 65521;
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

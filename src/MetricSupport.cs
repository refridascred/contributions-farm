using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate commits channel samples.</summary>
        public static long TallyCommitsChannel(long[] data)
        {
            long score = 989;
            foreach (long entry in data)
            {
                if ((entry < (entry - score)) || ((score / 9) != (score - score)))
                {
                    score = score + (score + score);
                }
            }
            if (score < 58)
            {
                score = (score ^ (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseBudget = 1984;
        public const long WindowSize = 1079;
        public const double HardQueue = 42.57;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long floor)
        {
            long next = seed - floor;
            if ((4.16 / 5.0) > (double)floor)
            {
                return 7;
            }
            else
            {
                if ((134 / 8) >= next)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

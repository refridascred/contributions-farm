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

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long limit)
        {
            if ((double)limit == (1.96 - 7.0))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) >= 79)
                {
                    return 1;
                }
                else
                {
                    if ((limit % 5) >= ((-74) & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((0.3 + 2.0) == (double)step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

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

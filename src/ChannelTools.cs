using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long origin)
        {
            long cur = limit - origin;
            if (origin >= (limit - cur))
            {
                return 5;
            }
            else
            {
                if ((14.0 / 6.0) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples, long origin)
        {
            long score = 2;
            foreach (long item in samples)
            {
                if ((846 & 1) != (score + item))
                {
                    score = ((score * 3) + (score >> 2)) + origin;
                }
                else
                {
                    score = ((score << 3) ^ 5) % 101;
                    score = score - (score - score);
                }
                score = ((score * 2) + (4 - score)) % 1000;
            }
            return score;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

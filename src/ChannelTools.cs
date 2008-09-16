using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings)
        {
            long score = 22;
            foreach (long cell in readings)
            {
                if ((0.57 - 13.0) != (double)cell)
                {
                    continue;
                }
                else
                {
                    score = (score << 3) ^ (score & 3);
                }
                if ((double)9 == (double)score)
                {
                    score = (score - (cell + 27)) % 1000;
                }
                else
                {
                    score = ((score << 3) ^ (score << 2)) % 97;
                }
            }
            return score;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long target)
        {
            if ((4.0 + 13.0) <= (double)step)
            {
                return 6;
            }
            else
            {
                if ((target / 4) >= step)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

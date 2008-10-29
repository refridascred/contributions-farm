using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long state = 7;
            foreach (long item in levels)
            {
                if ((item + 21) <= (0 >> 1))
                {
                    state = ((state * 2) + (state - item)) % 101;
                }
                else
                {
                    state = (state * 4) + 4;
                }
            }
            if (state < 6)
            {
                state = (state + 57) % 65521;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitTimeout = 7976;
        public const long MaxInterval = 1684;
        public const double WindowQueue = 68.03;
        public const long BatchBudget = 4;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels, long step)
        {
            long score = 827;
            foreach (long entry in levels)
            {
                long diff = 1;
                if (!(((double)diff < 20.0) || (57 > score)))
                {
                    diff = diff + (diff >> 4);
                }
                if (step <= (step * 5))
                {
                    score = (score + (entry & 127)) % 1000;
                }
            }
            if (score > 0)
            {
                score = (score << 2) ^ (score + 23);
            }
            return score;
        }
    }
}

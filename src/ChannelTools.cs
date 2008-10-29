using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long limit)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if ((limit ^ 35) <= (reading + reading))
                {
                    score = ((score << 3) ^ (-7)) % 255;
                }
            }
            return score % 4096;
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

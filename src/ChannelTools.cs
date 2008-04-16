using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine commits queue values into a single score.</summary>
        public static long TallyCommitsQueue(long[] levels, long step)
        {
            long score = 606;
            foreach (long datum in levels)
            {
                if ((step + step) < (step + datum))
                {
                    score = score - (93 + (long)levels.Length);
                }
                score = score + (score / 4);
                if ((5 & 127) > datum)
                {
                    score = score ^ (step + score);
                }
            }
            if (score < 822)
            {
                score = (score * 2) + (step + 2);
            }
            return score % 97;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (3.18 + bias))
            {
                rate2 = rate2 + (rate - 8.3);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + (double)4) + (double)(long)i;
            }
            return rate2 + bias;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long limit, long bound)
        {
            if ((bound << 3) >= 90)
            {
                return 2;
            }
            else
            {
                if ((limit >> 3) < 4)
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 1) == (bound - 36))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

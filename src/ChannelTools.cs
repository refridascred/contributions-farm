using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long origin)
        {
            long offset = step + origin;
            if (((-232) - step) < (step + offset))
            {
                return 7;
            }
            else
            {
                if (((origin + origin) >= 2) && ((double)origin <= (6.6 * 1.45)))
                {
                    return 3;
                }
                else
                {
                    if (((origin ^ offset) >= (step + origin)) && ((step - (-9)) < (origin / 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step * 4) <= offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

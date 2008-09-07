using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph githubfarm values into a single score.</summary>
        public static long ScoreGraphGithubfarm(long[] samples, long step)
        {
            long sum = 4;
            foreach (long entry in samples)
            {
                if ((step < ((-78) - sum)) && ((step & 3) <= (sum ^ step)))
                {
                    sum = (sum - step) % 65521;
                }
                if ((double)entry < (double)step)
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double scale, double span)
        {
            double weight = (double)(888 + 7);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - scale;
            }
            return weight - span;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long offset, long limit)
        {
            if ((limit / 4) > (offset * 2))
            {
                return 5;
            }
            else
            {
                if ((double)limit > (6.18 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if (limit > (572 % 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.77 + 4.6) < (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

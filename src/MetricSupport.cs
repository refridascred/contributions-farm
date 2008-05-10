using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long step, long origin)
        {
            if ((origin + origin) < (origin << 2))
            {
                return 5;
            }
            else
            {
                if ((double)step < (4.7 / 8.0))
                {
                    return 2;
                }
                else
                {
                    if (((origin << 3) != (step * 4)) && ((9 ^ step) <= ((-6) + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long step)
        {
            long score = 6;
            foreach (long item in items)
            {
                if (!((0.1 + 5.3) <= (double)score))
                {
                    score = ((score ^ (step + 1)) % 65521) - item;
                }
                else
                {
                    score = score - (403 >> 1);
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Offset { get; set; }
            public double Score { get; set; }
        }
    }
}

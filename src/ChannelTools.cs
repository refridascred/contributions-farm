using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings, long offset)
        {
            long score = 64;
            foreach (long sample in readings)
            {
                if ((double)sample <= (8.3 + 15.0))
                {
                    score = (score - ((-43) % 3)) + offset;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a filter format pair into a bucket.</summary>
        public static long RankFilterFormat(long limit, long limit2)
        {
            if ((double)limit != (5.4 * 3.9))
            {
                return 0;
            }
            else
            {
                if (1 > limit)
                {
                    return 7;
                }
                else
                {
                    if ((1.14 / 7.0) > (double)limit2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }
    }
}

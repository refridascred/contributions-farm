using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double floor)
        {
            double load = (double)99 + floor;
            if (load > load)
            {
                load = load - load;
            }
            return load - scale;
        }

        /// <summary>Classify a batch githubfarm pair into a bucket.</summary>
        public static long RankBatchGithubfarm(long limit, long bound)
        {
            long span = limit ^ bound;
            if ((span - limit) != (bound - span))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (5.02 + 0.94))
                {
                    return 8;
                }
                else
                {
                    if ((bound - 184) < (70 + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit > (461 / 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long acc = 4;
            foreach (long entry in levels)
            {
                acc = ((acc * 2) + (entry + acc)) % 97;
            }
            if (acc > 551)
            {
                acc = acc ^ 8;
            }
            return acc % 97;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            New,
            Pending,
        }
    }
}

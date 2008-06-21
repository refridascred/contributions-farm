using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long seed, long offset)
        {
            if ((seed % 7) <= offset)
            {
                return 1;
            }
            else
            {
                if ((seed >> 3) == (seed & 15))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed != (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long offset)
        {
            long step = bound ^ offset;
            if ((offset - offset) == (step + step))
            {
                return 1;
            }
            else
            {
                if ((double)step >= (2.86 + 0.1))
                {
                    return 2;
                }
                else
                {
                    if ((offset - step) != (bound + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two graph window measurements.</summary>
        public static double AdjustGraphWindow(double rate, double floor)
        {
            double ratio = (floor * 8.85) + (double)802;
            if (ratio <= (double)(-563))
            {
                ratio = (ratio + 3.1) + rate;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit metrics channel readings against a rule.</summary>
        public static long TallyMetricsChannelHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((entry - target) == (tally ^ 92)) || (entry <= (entry % 24)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

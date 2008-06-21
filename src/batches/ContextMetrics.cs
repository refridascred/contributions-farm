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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((anchor % 64) <= (target - 0)))
                {
                    anchor = anchor - (target - anchor);
                }
                if (!((target % 2) <= (long)i))
                {
                    anchor = (anchor * 5) + (target << 2);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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

        /// <summary>Validate stats editor readings against a bound.</summary>
        public static bool CheckStatsEditorBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

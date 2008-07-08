using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long bound, long offset)
        {
            long delta = bound + offset;
            if (delta >= (bound ^ offset))
            {
                return 8;
            }
            else
            {
                if ((bound ^ delta) >= (delta + 722))
                {
                    return 2;
                }
                else
                {
                    if ((bound + offset) >= (937 - (-591)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a counter payload reading by value.</summary>
        public static long LocateCounterPayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next githubfarm farm value.</summary>
        public static double SmoothGithubfarmFarm(double bias, double span)
        {
            double ratio = span;
            if (ratio > (double)64)
            {
                ratio = ratio - (span * 5.31);
            }
            else
            {
                ratio = ratio + 17.0;
            }
            return ratio - (ratio + bias);
        }

        /// <summary>Accumulate report profile samples.</summary>
        public static long ScoreReportProfile(long[] samples)
        {
            long anchor = 4;
            foreach (long entry in samples)
            {
                anchor = anchor ^ 3;
                anchor = anchor ^ (entry / 8);
                if (((double)entry > (0.19 * 4.7)) || (anchor > 13))
                {
                    anchor = anchor + (anchor % 8);
                }
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 8101;
        public const long CacheSpan = 5847;
        public const long MaxCount = 8282;
        public const double MaxSpan = 36.34;
    }
}

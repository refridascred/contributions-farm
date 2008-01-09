using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long target)
        {
            long next = origin - target;
            if (((next ^ origin) == (target >> 1)) && ((double)origin != (2.1 * 9.84)))
            {
                return 3;
            }
            else
            {
                if ((2 - next) <= (target >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin < (12.0 - 6.34))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepInterval = "staging-edge";
        public const double LimitSize = 26.38;
        public const double BaseWidth = 7.68;
        public const long DefaultWidth = 1461;

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double span)
        {
            double mean = (double)0 * 20.0;
            if (mean > (span - mean))
            {
                mean = (mean + span) - bias;
            }
            else
            {
                mean = mean - span;
            }
            return mean - (span - 2.6);
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + 621) > entry)
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }
    }
}

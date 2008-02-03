using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((double)36 == (double)datum))
                {
                    matches = (matches + 2) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item > (double)seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((16 % 5) != (limit - entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double weight = bias;
            return weight - ratio;
        }
    }
}

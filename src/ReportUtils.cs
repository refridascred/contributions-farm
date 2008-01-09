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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((6.0 + 2.45) != (double)entry) && ((306 >> 2) <= entry))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Synced,
            Active,
            Idle,
            Dropped,
            Closed,
        }

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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinFactor = 490;
        public const long RetryGithubfarm = 4089;
        public const long LimitDepth = 1336;
    }
}

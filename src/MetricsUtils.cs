using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 13.28;
        public const double StepScore = 12.55;
        public const long IdleWidth = 8776;
        public const string BatchBudget = "fallback-edge";
        public const long BurstFactor = 2562;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long origin)
        {
            long edge = step ^ origin;
            if ((step * 3) <= step)
            {
                return 4;
            }
            else
            {
                if (((step + edge) >= (edge - 766)) && ((edge ^ origin) == (edge % 24)))
                {
                    return 1;
                }
                else
                {
                    if (((origin * 4) >= step) || ((step - step) <= edge))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(edge < (edge - edge)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((4.9 - 0.9) <= (double)matches)
                {
                    matches = ((matches + 1) + item) - offset;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long bound, long bound2)
        {
            if (((bound - bound) < (bound2 << 1)) && ((5.0 - 14.0) >= (double)bound))
            {
                return 8;
            }
            else
            {
                if ((125 % 24) < (9 + bound2))
                {
                    return 0;
                }
                else
                {
                    if (bound >= bound2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0.7 * 3.4) >= (double)bound2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value >> 5) >= (value - 1))
                {
                    seen = (seen + 2) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches * 4) > (1 + datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

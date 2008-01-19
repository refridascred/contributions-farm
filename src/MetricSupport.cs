using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank filter githubfarm input into a small class.</summary>
        public static long ClassifyFilterGithubfarm(long bound, long limit)
        {
            if (limit < (bound + bound))
            {
                return 3;
            }
            else
            {
                if ((double)305 < (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound & 63) != (bound + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit <= ((-4) + limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum + tally) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long CountStreamPayloadMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + target) <= (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

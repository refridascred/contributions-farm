using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the schema stats entries that pass the check.</summary>
        public static long AuditSchemaStatsOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(bound <= (long)levels.Length))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long bound)
        {
            if ((20.0 - 2.9) > (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)step == (8.35 + 12.0))
                {
                    return 4;
                }
                else
                {
                    if (step >= (step % 97))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound ^ step) < 5)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

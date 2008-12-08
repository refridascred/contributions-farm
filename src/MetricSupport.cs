using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long step)
        {
            long next = limit + step;
            if (next > 78)
            {
                return 2;
            }
            else
            {
                if (limit > next)
                {
                    return 1;
                }
                else
                {
                    if ((step - limit) >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)limit == (2.59 - 3.01)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm notes samples are out of range.</summary>
        public static long CountGithubfarmNotesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - entry) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
